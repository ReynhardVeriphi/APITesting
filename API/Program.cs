var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/health", () => Results.Ok("OK"));

// dotnet run --launch-profile http

app.Run();
