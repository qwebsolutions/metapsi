using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;

namespace Metapsi
{
    public static class Mds
    {
        public static class ExitCode
        {
            // A startup error is written to a predefined file name that gets checked by MdsLocal. The service gets dropped.
            public const int StartupError = 55001;
        }

        public static class Constant
        {
            public const string ParametersFileName = "parameters.json";
            public const string MdsFileName = "mds.json";
            public const string ShutdownFileName = "shutdown.json";
            public const string RedisUrl = "RedisUrl";
            public const string LogDbFile = "log.db";
            public const string LogTextFile = "log.txt";
            public const string CommandDbFile = "command.db";
            public const string InfrastructureNameVariable = "$InfrastructureName";
            public const string ServiceNameVariable = "$ServiceName";
        }


        // Searches upfolder from executing binary for parameters.json. If mds.json is also found in the same folder, 
        // common properties from parameters.json are overwritten with values from mds.json.
        // This allows full configuration in a development environment & split configuration when released.
        public static Dictionary<string, string> LoadParameters(string parameterFileName = Constant.ParametersFileName)
        {
            string parametersFilePath = GetParametersFilePath(parameterFileName);

            string fileContent = System.IO.File.ReadAllText(parametersFilePath);
            Dictionary<string, string> parameters = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(fileContent);
            string filesDirectory = System.IO.Path.GetDirectoryName(parametersFilePath);
            string mdsFilePath = System.IO.Path.Combine(filesDirectory, Constant.MdsFileName);
            if (System.IO.File.Exists(mdsFilePath))
            {
                string mdsFileContent = System.IO.File.ReadAllText(mdsFilePath);
                Dictionary<string, string> mdsParameters = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(mdsFileContent);
                parameters[nameof(Mds.InstallationData.ServiceName)] = mdsParameters[nameof(Mds.InstallationData.ServiceName)];
                parameters[nameof(Mds.InstallationData.InfrastructureName)] = mdsParameters[nameof(Mds.InstallationData.ServiceName)];
                parameters[nameof(Mds.InstallationData.DataFolder)] = mdsParameters[nameof(Mds.InstallationData.DataFolder)];
                parameters[nameof(Mds.InstallationData.Version)] = mdsParameters[nameof(Mds.InstallationData.Version)];
                parameters[nameof(Mds.InstallationData.InstalledOn)] = mdsParameters[nameof(Mds.InstallationData.InstalledOn)];
            }

            // This also works without mds.json, as these parameters can be added by hand in the parameters file
            SubstituteParameters(parameters);

            return parameters;
        }

        public static string GetParametersFilePath(string parameterFileName = Constant.ParametersFileName)
        {
            string parametersFilePath = parameterFileName;

            if (!System.IO.File.Exists(parameterFileName)) // Is not some qualified path or a file in the current directory
            {
                parametersFilePath = RelativePath.SearchUpfolder(RelativePath.From.EntryPath, parameterFileName);
            }

            return parametersFilePath;
        }

        public static void SubstituteParameters(Dictionary<string, string> parameters, Dictionary<string, string> extraValues = null)
        {
            Dictionary<string, string> merged = new Dictionary<string, string>(parameters);
            if (extraValues != null)
            {
                foreach (var kv in extraValues)
                {
                    merged[kv.Key] = kv.Value;
                }
            }

            // Simple attempt at parameter substitution. Not recursive (yet), hopefully never ...
            foreach (string key in parameters.Keys.ToList())
            {
                parameters[key] = SubstituteVariables(parameters[key], merged);
            }
        }

        /// <summary>
        /// Returns substitution variables without $( ) characters
        /// </summary>
        /// <param name="inString"></param>
        /// <returns></returns>
        public static IEnumerable<string> GetAllVariables(string inString)
        {
            HashSet<string> variables = new HashSet<string>();

            int handledIndex = 0;

            while (true)
            {
                var nextVarStart = inString.IndexOf("$(", handledIndex);

                if (nextVarStart < 0)
                    break;

                var nextVarEnd = inString.IndexOf(")", nextVarStart);
                string varName = inString.Substring(nextVarStart, nextVarEnd - nextVarStart + 1);
                variables.Add(varName.Replace("$(", string.Empty).Replace(")", string.Empty));

                handledIndex = nextVarEnd;
            }

            return variables;
        }

        public static string SubstituteVariable(string inParameterValue, string variableName, string value)
        {
            if (!variableName.StartsWith("$("))
            {
                variableName = $"$({variableName})";
            }

            return inParameterValue.Replace(variableName, value);
        }

        public static string SubstituteVariables(string inConfiguredValue, Dictionary<string, string> substitutionValues)
        {
            var allVariables = GetAllVariables(inConfiguredValue);

            foreach (string variable in allVariables)
            {
                // Some substitutions are performed dynamically, eg. in an API call,
                // so don't throw exception if substitution parameter is not available

                string replacementValue = null; // Not string.Empty, this is a valid value

                if (substitutionValues.ContainsKey(variable))
                {
                    replacementValue = substitutionValues[variable];
                }

                if (replacementValue != null)
                {
                    inConfiguredValue = SubstituteVariable(inConfiguredValue, variable, replacementValue);
                }
            }

            return inConfiguredValue;
        }

        public static T LoadParameters<T>(string parameterFileName = Constant.ParametersFileName) where T : new()
        {
            return ParametersAs<T>(LoadParameters(parameterFileName));
        }

        public static T ParametersAs<T>(Dictionary<string, string> parameters) where T : new()
        {
            T typed = new T();
            foreach (var parameter in parameters)
            {
                var property = typeof(T).GetProperty(parameter.Key);
                if (property != null)
                {
                    if (property.PropertyType == typeof(int))
                    {
                        property.SetValue(typed, System.Convert.ToInt32(parameter.Value));
                    }
                    else if (property.PropertyType == typeof(bool))
                    {
                        property.SetValue(typed, System.Convert.ToBoolean(parameter.Value));
                    }
                    else property.SetValue(typed, parameter.Value);
                }
            }

            return typed;
        }

        public class ServiceSetup
        {
            public ApplicationSetup ApplicationSetup { get; set; }
            public Dictionary<string, string> Parameters { get; set; } = new Dictionary<string, string>();
            public string ServiceName { get; set; }
            public string InfrastructureName { get; set; }
            public string FullServiceName { get; set; }
            public string ServiceDataFolder { get; set; }
            public string ServiceLogDbFile { get; set; }
            public string ServiceLogTextFile { get; set; }
            public string ServiceCommandDbFile { get; set; }

            // Tasks to await on shutdown
            public List<Task> ShutdownTasks { get; set; } = new List<Task>();

            public T ParametersAs<T>() where T : new()
            {
                return Mds.ParametersAs<T>(this.Parameters);
            }

            public static ServiceSetup New()
            {
                ServiceSetup serviceSetup = new ServiceSetup();
                serviceSetup.Parameters = LoadParameters();
                FillSetup(serviceSetup);
                return serviceSetup;
            }

            public static ServiceSetup New(Dictionary<string, string> parameters)
            {
                ServiceSetup serviceSetup = new ServiceSetup() { Parameters = parameters };
                FillSetup(serviceSetup);
                return serviceSetup;
            }

            private static void FillSetup(ServiceSetup serviceSetup)
            {
                DateTime startTimestamp = DateTime.UtcNow;

                if (!serviceSetup.Parameters.ContainsKey(nameof(Mds.InstallationData.ServiceName)))
                {
                    throw new Exception("Service name is mandatory!");
                }

                if (!serviceSetup.Parameters.ContainsKey(nameof(Mds.InstallationData.InfrastructureName)))
                {
                    throw new Exception("Infrastructure name is mandatory!");
                }

                string serviceDataFolder = string.Empty;

                if (serviceSetup.Parameters.ContainsKey(nameof(Mds.InstallationData.DataFolder)))
                {
                    serviceDataFolder = serviceSetup.Parameters[nameof(Mds.InstallationData.DataFolder)];
                }

                serviceSetup.ServiceName = serviceSetup.Parameters[nameof(Mds.InstallationData.ServiceName)];
                serviceSetup.InfrastructureName = serviceSetup.Parameters[nameof(Mds.InstallationData.InfrastructureName)];
                serviceSetup.ApplicationSetup = ApplicationSetup.New();
                serviceSetup.FullServiceName = $"{serviceSetup.InfrastructureName}.{serviceSetup.ServiceName}";
                serviceSetup.ServiceDataFolder = GetServiceDataFolder(serviceDataFolder, serviceSetup.ServiceName);
                serviceSetup.ServiceLogDbFile = serviceSetup.GetServiceDataFile(Constant.LogDbFile);
                serviceSetup.ServiceLogTextFile = serviceSetup.GetServiceDataFile(Constant.LogTextFile);
                serviceSetup.ServiceCommandDbFile = serviceSetup.GetServiceDataFile(Constant.CommandDbFile);
                
                serviceSetup.CreateServiceLogDbFile();
                serviceSetup.ApplicationSetup.OnLogMessage = (logData) => DefaultLog(serviceSetup, startTimestamp, logData);
                serviceSetup.ApplicationSetup.PoolCommandDb(serviceSetup.ServiceCommandDbFile, startTimestamp);
            }

            public void ValidateMissingParameters(
                Dictionary<string, string> parameters,
                IEnumerable<string> mandatoryParameters)
            {
                Mds.ValidateMissingParameters(parameters, mandatoryParameters, ApplicationSetup.OnLogMessage).Wait();
            }

            public void ValidateMissingParameters(IEnumerable<string> mandatoryParameters)
            {
                Mds.ValidateMissingParameters(Parameters, mandatoryParameters, ApplicationSetup.OnLogMessage).Wait();
            }

            public string Version(string defaultVersion)
            {
                return Parameters.ContainsKey(nameof(Mds.InstallationData.Version))
                    ?
                    Parameters[nameof(Mds.InstallationData.Version)] :
                    string.Empty;
            }

            public Application Revive()
            {
                Application application = null;
                this.ApplicationSetup.MapEvent<Event.Shutdown>(
                    e =>
                    {
                        if (application != null)
                        {
                            e.Logger.LogInfo("Application is shutting down");
                            var _ = application.Suspend(ShutdownTasks.ToArray());// Do not await
                        }
                    });

                application = this.ApplicationSetup.Revive();
                return application;
            }

            private void CreateServiceLogDbFile()
            {
                Mds.CreateServiceLogDbFile(ServiceLogDbFile);
            }

        }

        /// <summary>
        /// mds.json
        /// </summary>
        public class InstallationData
        {
            public string InfrastructureName { get; set; } = System.String.Empty;
            public string NodeName { get; set; } = System.String.Empty;
            public string ServiceName { get; set; } = System.String.Empty;
            public string ConfigurationId { get; set; } = System.String.Empty;
            public string ProjectName { get; set; } = System.String.Empty;
            public string Version { get; set; } = System.String.Empty;
            public string InstalledOn { get; set; } = System.String.Empty;
            public string DataFolder { get; set; } = System.String.Empty;
        }

        public static string GetServiceDataFolder(string baseDataFolder, string serviceName)
        {
            // This is useful in development
            if(string.IsNullOrEmpty(baseDataFolder))
            {
                string mdsBasePath = RelativePath.SearchUpfolder(RelativePath.From.EntryPath, "mds");
                baseDataFolder = System.IO.Path.Combine(mdsBasePath, "mds", "data");
            }

            if (baseDataFolder.Contains(serviceName))
                return baseDataFolder;

            return System.IO.Path.Combine(baseDataFolder, serviceName);
        }

        public static string GetServiceLogDbFile(string baseDataFolder, string serviceName)
        {
            return System.IO.Path.Combine(GetServiceDataFolder(baseDataFolder, serviceName), Constant.LogDbFile);
        }

        public static string GetServiceLogTextFile(string baseDataFolder, string serviceName)
        {
            return System.IO.Path.Combine(GetServiceDataFolder(baseDataFolder, serviceName), Constant.LogTextFile);
        }

        public static string GetServiceCommandDbFile(string baseDataFolder, string serviceName)
        {
            return System.IO.Path.Combine(GetServiceDataFolder(baseDataFolder, serviceName), Constant.CommandDbFile);
        }

        public static string GetServiceDataFile(string baseDataFolder, string serviceName, params string[] pathSegments)
        {
            List<string> segments = new List<string>();
            segments.Add(GetServiceDataFolder(baseDataFolder, serviceName));
            segments.AddRange(pathSegments);
            return System.IO.Path.Combine(segments.ToArray());
        }

        public static string GetServiceDataFile(this ServiceSetup serviceSetup, params string[] pathSegments)
        {
            List<string> segments = new List<string>();
            segments.Add(serviceSetup.ServiceDataFolder);
            segments.AddRange(pathSegments);
            return System.IO.Path.Combine(segments.ToArray());
        }

        public static async Task DefaultLog(ServiceSetup serviceSetup, DateTime startTimestampUtc, LogMessage logMessage)
        {
            Console.WriteLine(logMessage);

            switch (logMessage.Message)
            {
                case Metapsi.Log.Info info:
                    {
                        await LogToServiceText(serviceSetup.ServiceLogTextFile, startTimestampUtc, logMessage);
                        await LogToServiceDb(serviceSetup.ServiceLogDbFile, startTimestampUtc, logMessage);
                    }
                    break;
                case Mds.StartupError startupError:
                    {
                        await LogToServiceText(serviceSetup.ServiceLogTextFile, startTimestampUtc, logMessage);
                        await LogToServiceDb(serviceSetup.ServiceLogDbFile, startTimestampUtc, logMessage);
                    }
                    break;
                case Metapsi.Log.Error error:
                    {
                        await LogToServiceText(serviceSetup.ServiceLogTextFile, startTimestampUtc, logMessage);
                        await LogToServiceDb(serviceSetup.ServiceLogDbFile, startTimestampUtc, logMessage);
                    }
                    break;
                case Metapsi.Log.Exception exception:
                    {
                        await LogToServiceText(serviceSetup.ServiceLogTextFile, startTimestampUtc, logMessage);
                        await LogToServiceDb(serviceSetup.ServiceLogDbFile, startTimestampUtc, logMessage);
                    }
                    break;
                case Metapsi.Log.Debug debug:
                    {
                        await LogToServiceText(serviceSetup.ServiceLogTextFile, startTimestampUtc, logMessage);
                    }
                    break;
            }
        }

        public static async Task ValidateMissingParameters(
            Dictionary<string, string> parameters,
            IEnumerable<string> mandatoryParameters,
            Func<LogMessage, Task> onLogMessage)
        {
            var missingParameters = mandatoryParameters.Except(parameters.Keys);
            if (missingParameters.Any())
            {
                await onLogMessage(new LogMessage()
                {
                    CallStack = new CallStack(null),
                    Message = new StartupError()
                    {
                        ErrorMessage = $"Missing parameters: {string.Join(",", missingParameters)}"
                    }
                });
                Environment.Exit(ExitCode.StartupError);
            }
        }

        /// <summary>
        /// Startup errors get forwarded to global controller. The process is intentionally crashed. Local controller does not attempt restart.
        /// Example: missing mandatory parameter
        /// </summary>
        public class StartupError : ILogMessage
        {
            public string ErrorMessage { get; set; }

            public override string ToString()
            {
                return ErrorMessage;
            }
        }

        public static void CreateServiceLogDbFile(string serviceLogDbFile)
        {
            if (!string.IsNullOrEmpty(serviceLogDbFile))
            {
                if (!System.IO.File.Exists(serviceLogDbFile))
                {
                    string folderPath = System.IO.Path.GetDirectoryName(serviceLogDbFile);
                    System.IO.Directory.CreateDirectory(folderPath);

                    using (var connection = new SQLiteConnection($"Data Source = {serviceLogDbFile}"))
                    {
                        connection.Open();

                        connection.Execute(@"CREATE TABLE ""Log"" (
                                ""Id"" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                ""ProcessStartTimestamp"" TEXT NOT NULL,
                                ""LogTimestamp"" TEXT NOT NULL,
                                ""LogMessageType""   TEXT NOT NULL,
                                ""LogMessage"" TEXT NOT NULL,
                                ""CallStack"" TEXT NOT NULL,
                                ""Processed"" INTEGER )");
                        Console.WriteLine($"Service log db created {serviceLogDbFile}");
                    }
                }
            }
        }

        public static void CreateServiceCommandDbFile(string serviceCommandDbFile)
        {
            if (!string.IsNullOrEmpty(serviceCommandDbFile))
            {
                if (!System.IO.File.Exists(serviceCommandDbFile))
                {
                    string folderPath = System.IO.Path.GetDirectoryName(serviceCommandDbFile);
                    System.IO.Directory.CreateDirectory(folderPath);

                    using (var connection = new SQLiteConnection($"Data Source = {serviceCommandDbFile}"))
                    {
                        connection.Open();

                        connection.Execute(@"CREATE TABLE ""Command"" (
                                ""Id""    INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                ""CommandTimestamp"" TEXT,
                                ""CommandDataType""  TEXT,
                                ""CommandData"" TEXT,
                                ""Processed"" INTEGER)");
                        Console.WriteLine($"Service command db created {serviceCommandDbFile}");
                    }
                }
            }
        }

        public static void ClearServiceCommands(string serviceDbPath)
        {
            if (!System.IO.File.Exists(serviceDbPath))
                return;

            using (var connection = new SQLiteConnection($"Data Source = {serviceDbPath}"))
            {
                connection.Open();
                connection.Execute(@"delete from Command");
            }
        }

        internal class Log
        {
            public string ProcessStartTimestamp { get; set; }
            public string CallStack { get; set; }
            public string LogMessageType { get; set; }
            public string LogMessage { get; set; }
            public string LogTimestamp { get; set; }
            public int Processed { get; set; }
        }

        internal class Command
        {
            public string CommandTimestamp { get; set; }
            public string CommandDataType { get; set; }
            public string CommandData { get; set; }
            public int Processed { get; set; }
        }

        public static async Task LogToServiceText(
            string serviceLogTxtPath,
            DateTime startTimestampUtc,
            LogMessage logMessage)
        {
            //Startup errors should always be logged. Other messages are logged only if the file exists
            if (!(logMessage.Message is StartupError))
            {
                if (string.IsNullOrEmpty(serviceLogTxtPath))
                    return;

                if (!System.IO.File.Exists(serviceLogTxtPath))
                    return;
            }

            string messageType = logMessage.Message.GetType().Name;

            if (messageType.Length > 10)
                messageType = messageType.Substring(0, 10);
            else messageType = messageType.PadRight(10);

            System.IO.File.AppendAllText(serviceLogTxtPath, $"{logMessage.TimestampUtc.Roundtrip()} {startTimestampUtc.Roundtrip()} {messageType} {logMessage.Message}\n");
        }

        public static async Task LogToServiceDb(
            string serviceDbPath,
            DateTime startTimestampUtc,
            LogMessage logMessage)
        {
            if (string.IsNullOrEmpty(serviceDbPath))
                return;

            if (!System.IO.File.Exists(serviceDbPath))
                return;

            using (SQLiteConnection conn = new SQLiteConnection($"Data Source = {serviceDbPath}"))
            {
                await conn.OpenAsync();
                var transaction = conn.BeginTransaction();

                var logEntry = new Log()
                {
                    ProcessStartTimestamp = startTimestampUtc.ToString("O", System.Globalization.CultureInfo.InvariantCulture),
                    CallStack = logMessage.CallStack.ToString(),
                    LogMessage = logMessage.Message.ToString(),
                    LogMessageType = logMessage.Message.GetType().Name,
                    LogTimestamp = logMessage.TimestampUtc.ToString("O", System.Globalization.CultureInfo.InvariantCulture),
                    Processed = 0
                };

                string insertStatement = Metapsi.Sqlite.DbAccess.GetInsertStatement(logEntry);
                await conn.ExecuteAsync(insertStatement, logEntry, transaction);
                transaction.Commit();
            }
        }

        public static async Task WriteCommand(
            string serviceDbPath,
            Mds.ICommand commandData)
        {
            if (string.IsNullOrEmpty(serviceDbPath))
                return;

            if (!System.IO.File.Exists(serviceDbPath))
                return;

            using (SQLiteConnection conn = new SQLiteConnection($"Data Source = {serviceDbPath}"))
            {
                conn.Open();
                var transaction = conn.BeginTransaction();

                var commandEntry = new Mds.Command()
                {
                    CommandTimestamp = DateTime.UtcNow.ToString("O", System.Globalization.CultureInfo.InvariantCulture),
                    CommandData = Serialize.ToJson(commandData),
                    CommandDataType = commandData.GetType().Name,
                    Processed = 0
                };

                string insertStatement = Metapsi.Sqlite.DbAccess.GetInsertStatement(commandEntry);

                await conn.ExecuteAsync(insertStatement, commandEntry, transaction);

                int currentMax = await conn.ExecuteScalarAsync<int>("select max(Id) from Command", transaction: transaction);
                int cutoffId = currentMax - 10;
                await conn.ExecuteAsync("delete from Command where Id <= @cutoffId", new { cutoffId }, transaction);
                transaction.Commit();
            }
        }

        public static async Task CheckCommands(
            CommandContext commandContext,
            string serviceCommandDbPath)
        {
            if (string.IsNullOrEmpty(serviceCommandDbPath))
                return;

            if (!System.IO.File.Exists(serviceCommandDbPath))
                return;

            using (SQLiteConnection conn = new SQLiteConnection($"Data Source = {serviceCommandDbPath}"))
            {
                conn.Open();
                var transaction = conn.BeginTransaction();

                var commands = await conn.QueryAsync<CommandEntry>("select * from Command where Processed = 0 order by id asc", transaction: transaction);
                Console.WriteLine($"Found {commands.Count()} commands");

                foreach(CommandEntry commandEntry in commands)
                {
                    commandContext.Logger.LogInfo($"Found command: {commandEntry.CommandDataType} {commandEntry.CommandData}");
                    switch(commandEntry.CommandDataType)
                    {
                        case nameof(Shutdown):
                            {
                                commandContext.PostEvent(new Event.Shutdown());
                            }
                            break;
                    }

                    int updatedRows = await conn.ExecuteAsync("update Command set Processed = 1 where Id = @Id", commandEntry, transaction);
                    Console.WriteLine($"Try update row with ID = {commandEntry.Id}, updated count {updatedRows}");
                }
                transaction.Commit();
            }
        }

        public class CommandEntry
        {
            public int Id { get; set; }
            public string CommandTimestamp { get; set; }
            public string CommandDataType { get; set; }
            public string CommandData { get; set; }
        }

        public interface ICommand
        {

        }

        public class Shutdown : ICommand
        {

        }

        public class Ping : ILogMessage
        {

        }

        public static class CommandDbPooler
        {
            public class State
            {
                public string ServiceCommandDbFile { get; set; }
                public DateTime ServiceStartTimestampUtc { get; set; }
                public int KeepMax { get; set; }
            }


            public static async Task CheckCommands(CommandContext commandContext, State state)
            {
                await Mds.CheckCommands(commandContext, state.ServiceCommandDbFile);
            }
        }

        public static void PoolCommandDb(
            this ApplicationSetup applicationSetup,
            string serviceCommandDbPath,
            DateTime serviceStartTimestampUtc)
        {
            var timer = applicationSetup.AddBusinessState(new Timer.State());
            var localDbLogger = applicationSetup.AddBusinessState(
                new CommandDbPooler.State()
                {
                    ServiceCommandDbFile = serviceCommandDbPath,
                    ServiceStartTimestampUtc = serviceStartTimestampUtc
                });

            applicationSetup.MapEvent<ApplicationRevived>(
                e =>
                {
                    Mds.ClearServiceCommands(serviceCommandDbPath);

                    e.Using(timer).EnqueueCommand(Timer.SetTimer, new Timer.Command.Set()
                    {
                        Name = "CommandTimer",
                        IntervalMilliseconds = Timer.FromSeconds(5)
                    });
                });

            applicationSetup.MapEventIf<Timer.Event.Tick>(
                e => e.Name == "CommandTimer",
                e =>
                {
                    e.Using(localDbLogger).EnqueueCommand(CommandDbPooler.CheckCommands);
                });
        }

        public static class Event
        {
            public class Shutdown : IData
            {

            }
        }
    }
}