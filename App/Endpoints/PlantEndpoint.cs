namespace GreenThumb.Endpoints;
using GreenThumb.Model;
using GreenThumb.Persistence;

public class PlantEndpoint : IEndpoint //,IPlantEndpoint
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
    }
}
public interface IPlantEndpoint
{
    public Task InsertPlant(Plant plant);
    public Task<Plant> GetPlant(int plantId);
    public Task<List<Plant>> GetAllPlants();
    public Task DeletePlant(int plantId);
}