using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/healthz", () => new { status = "ok" });
app.MapGet("/", () => "Hello World!");

app.Run();
