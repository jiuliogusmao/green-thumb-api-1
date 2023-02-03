using GreenThumb.Model;
namespace GreenThumb.Persistence
{
	public class PlantDatabaseService : IDatabaseService
	{
		private readonly PlantDbContext _context;
		public PlantDatabaseService(PlantDbContext context)
		{
			_context = context;
		}
		public async Task<List<Plant>> GetPlants()
		{
			return await _context.Plants.ToListAsync();
		}
		public async Task AddPlant(Plant plant)
		{
			await _context.Plants.AddAsync(plant);
			await _context.SaveChangesAsync();
		}
		public async Task<Plant> GetPlant(int plantId)
		{
            var plants = await _context.Plants
                    .Where(p => p.PlantId == plantId).ToListAsync();
            return plants.Count > 0 ? plants[0] : new Plant {};
        }
	}

	public interface IDatabaseService
	{
		Task<List<Plant>> GetPlants();
		Task AddPlant(Plant plant);
        Task<Plant> GetPlant(int plantId); //Task é o que torna essa assinatura de método assíncrona
    }
}

