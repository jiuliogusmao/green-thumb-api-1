using GreenThumb.Model;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDIServices();
builder.Services.AddCors();
var app = builder.Build();

app.UseOpenApi();
app.UseEndpoints();

app.UseCors(options =>
    options.WithOrigins("http://localhost:4200", "https://gentle-plant-06a96d810.2.azurestaticapps.net")
    .AllowAnyMethod()
    .AllowAnyHeader()
);
app.Run();