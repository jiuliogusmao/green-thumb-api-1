using Microsoft.OpenApi.Models;
using GreenThumb.Endpoints;
public static class DependencyInitializer
{
    public static IServiceCollection AddDIServices(this IServiceCollection services)
    {
        //services.AddTransient<IPlantEndpoint, PlantEndpoint>();
        
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "GreenThumbAPI", Version = "v1" });
        });

        return services;
    }
    public static IApplicationBuilder UseOpenApi(this IApplicationBuilder builder)
    {
        builder.UseSwagger();
        builder.UseSwaggerUI(c => {
            c.RoutePrefix = ""; c.SwaggerEndpoint("/swagger/v1/swagger.json", "Green Thumb v0.1");
            });
        return builder;
    }
    public static WebApplication UseEndpoints(this WebApplication app)
    {
        var endpoints = app.Services.GetServices<IEndpoint>().ToList();
        
        endpoints.ForEach(e => e.RegisterRoutes(app));

        return app;
    }
}