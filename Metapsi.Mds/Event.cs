using System;

namespace Metapsi
{
    public static partial class Mds
    {
        public static class Event
        {
            public class Shutdown : IData
            {

            }

            public class ServiceCrash
            {
                public string TimestampIso { get; set; } = DateTime.UtcNow.Roundtrip();
                public string InfrastructureName { get; set; }
                public string NodeName { get; set; }
                public string ServiceName { get; set; }
                public string ProcessPath { get; set; }
                public int ExitCode { get; set; } = 0;
                public string Exception { get; set; } = string.Empty;
            }
        }
    }
}