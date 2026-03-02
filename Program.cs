var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "i am luis...");

app.Run();
