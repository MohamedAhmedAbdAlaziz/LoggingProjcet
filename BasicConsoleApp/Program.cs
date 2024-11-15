using Microsoft.Extensions.Logging;
 
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;


using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureLogging(x =>
    {
        x.AddJsonConsole();
 
    }).Build();


var looger = host.Services.GetRequiredService<ILogger<Program>>();



using var loggerFactory = LoggerFactory.Create(builder =>
{

    builder.AddJsonConsole(option =>
    {
        option.IncludeScopes = false;
        option.TimestampFormat = "HH:mm:ss";
        option.JsonWriterOptions = new System.Text.Json.JsonWriterOptions
        {
            Indented = true
        };
    });
    
    builder.ClearProviders();
    builder.AddSystemdConsole();
    builder.SetMinimumLevel(LogLevel.Debug);
});

ILogger CreateLogger()
{
    return loggerFactory.CreateLogger("Course");
}

ILogger logger = loggerFactory.CreateLogger<Program>();

logger.LogInformation("Helow");
logger.Log(LogLevel.Information , 1 ,"Hello world");
logger.Log(LogLevel.Error , 2 ,"Hello world");
logger.LogDebug(3,"Hello LogDebug");



//ILogger logger2 = CreateLogger();

//logger2.LogInformation("Cources");


//ILogger logger3 = loggerFactory.CreateLogger<Sallam>();

//logger3.LogInformation("Cources");



public class Sallam
{

}