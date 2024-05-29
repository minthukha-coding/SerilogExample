using Serilog;

Log.Logger = new LoggerConfiguration()
        .MinimumLevel.Debug()
        .WriteTo.Console()
        .WriteTo.File("logs/SerilogExample.txt", rollingInterval: RollingInterval.Hour)
        .CreateLogger();

try
{
    Log.Information("Application Starting");

    int a = 10, b = 0;
    Log.Debug("Attempting to divide {A} by {B}", a, b);

    Console.WriteLine(a / b);
}
catch (Exception ex)
{
    Log.Warning(ex, "An error occurred while dividing numbers");
}
finally
{
    Log.Information("Application Ending");
    await Log.CloseAndFlushAsync();
}

Console.ReadKey();