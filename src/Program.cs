using Microsoft.Extensions.Logging;
using NeoSimpleLogger;

namespace SFTG;

internal class Program
{
    public static readonly Logger ConsoleLogger = new Logger(Logger.OutputType.Console);

    private static void Main() => ConsoleLogger.LogInformation("Program was been launched");
}