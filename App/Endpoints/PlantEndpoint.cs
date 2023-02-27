namespace GreenThumb.Endpoints;
using GreenThumb.Model;
using GreenThumb.Persistence;

public class PlantEndpoint : IEndpoint
{
    private IDatabaseService _service;
    public PlantEndpoint(IDatabaseService service)
    {
        _service = service;
    }
    public void RegisterRoutes(IEndpointRouteBuilder app)
    {
        app.MapPut("add-plant", async (Plant plant) =>
        {
            await _service.AddPlant(plant);
        });
        app.MapGet("list-plants", async () =>
        {
            return await _service.GetPlants();
        }); 
        app.MapGet("get-plant", async (int plantId) =>
        {
            return await _service.GetPlant(plantId);
        });
        app.MapPut("add-species", async (Species species) =>
        {
            await _service.AddSpecies(species);
        });
        app.MapGet("get-species", async () =>
        {
            return await _service.GetSpecies();
        });
    }
}