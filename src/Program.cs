using Avalonia;
using Microsoft.Extensions.Logging;
using NeoSimpleLogger;
using System;

namespace SFTG;

class Program
{
    public readonly static Logger ConsoleLogger = new Logger(Logger.OutputType.Console);
    [STAThread]
    public static void Main(string[] args)
    {
        ConsoleLogger.LogInformation("Program was been launched");
        BuildAvaloniaApp()
                .StartWithClassicDesktopLifetime(args);
    }

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace();
}
