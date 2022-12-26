var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDIServices();
var app = builder.Build();

app.UseOpenApi();
app.UseEndpoints();

GreenThumb.Model.Plant plant = new();
app.MapGet("/test", () => "Hello World!");
app.MapGet("/plant-name", plant.Name);


app.Run();
