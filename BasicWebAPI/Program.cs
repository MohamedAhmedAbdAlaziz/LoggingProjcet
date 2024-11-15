var builder = WebApplication.CreateBuilder(args);


builder.Host 
    .ConfigureLogging (x =>
    {
        x.AddJsonConsole();
    });

builder.Logging.AddJsonConsole();
//var looger = host.Services.GetRequiredService<ILogger<Program>>();


// Add services to the container.
builder.Logging.ClearProviders();
builder.Logging.AddSystemdConsole();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
