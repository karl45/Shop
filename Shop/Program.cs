using Shop.StartupExtensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureServices();

var app = builder.Build();

app.MapRoutes();
app.Run();