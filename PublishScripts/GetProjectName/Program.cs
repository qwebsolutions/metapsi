// See https://aka.ms/new-console-template for more information
var projectName = args[0].Split('/').Last().Split('\\').Last().Replace(".csproj", string.Empty);
Console.WriteLine(projectName);