using Microsoft.Extensions.Logging;

#region secret 🤭

using var loggerFactory = LoggerFactory.Create(builder =>
{
#pragma warning disable CA1416
    builder
        .AddConsole();
#pragma warning restore CA1416
});

ILogger CreateLogger()
{
    return loggerFactory.CreateLogger("Course");
}
#endregion

ILogger logger = loggerFactory.CreateLogger<Program>();

logger.LogInformation("Helow");



ILogger logger2 = CreateLogger();

logger2.LogInformation("Cources");


ILogger logger3 = loggerFactory.CreateLogger<Sallam>();

logger3.LogInformation("Cources");



public class Sallam
{

}