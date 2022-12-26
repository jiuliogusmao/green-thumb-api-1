using GreenThumb.Model;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDIServices();
var app = builder.Build();

app.UseOpenApi();
app.UseEndpoints();

Plant plant = new();
app.MapGet("/test", () => "Hello World!");
app.MapGet("/plant-name", plant.Name);


app.Run();