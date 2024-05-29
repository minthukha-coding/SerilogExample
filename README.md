# Serilog Example Documentation

This example demonstrates configuring Serilog to log messages to both the console and a file (`logs/SerilogExample.txt`) with an hourly rolling interval. The code logs the start and end of the application, attempts to divide two numbers, and catches any exceptions to log them as warnings. Ensure the Serilog and Serilog.Sinks.File packages are installed in your project. Use `Log.Information` for general messages, `Log.Debug` for debugging details, and `Log.Warning` for errors. Finally, `Log.CloseAndFlushAsync` ensures proper log flushing and closure.
