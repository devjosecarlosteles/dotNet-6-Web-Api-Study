var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("user", (HttpResponse response) => response.StatusCode = 200);

app.Run();
