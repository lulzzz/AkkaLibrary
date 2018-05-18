///////////////////////////////////////////////////////////////////////////////
// ARGUMENTS
///////////////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Debug");
var runtime = Argument("runtime", "linux-x64");
var framework = Argument("framework", "netcoreapp2.0");

///////////////////////////////////////////////////////////////////////////////
// Standard parameters
///////////////////////////////////////////////////////////////////////////////
readonly string OutputDirectoryRoot = "./_output/";
readonly string BuildDirectory = $"{OutputDirectoryRoot}Build/";
readonly string TestDirectory = $"{OutputDirectoryRoot}Tests/";
readonly string TestResultsDirectory = $"{OutputDirectoryRoot}/TestResults/";
readonly string TestHarnessDirectory = $"{OutputDirectoryRoot}/TestHarness/";
public static class TaskDescriptions
{
    public static readonly string Build = "Build";
    public static readonly string Clean = "Clean";
    public static readonly string Run = "Run";
    public static readonly string BuildTest = "BuildTest";
    public static readonly string RunTest = "RunTest";
    public static readonly string Nuget = "Nuget";
}