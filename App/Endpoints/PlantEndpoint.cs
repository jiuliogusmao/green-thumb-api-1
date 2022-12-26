namespace GreenThumb.Endpoints;
using GreenThumb.Model;

public class PlantEndpoint //:IPlantEndpoint
{

}
public interface IPlantEndpoint
{
    public Task InsertPlant(Plant plant);
    public Task<Plant> GetPlant(int plantId);
    public Task<List<Plant>> GetAllPlants();
    public Task DeletePlant(int plantId);
}