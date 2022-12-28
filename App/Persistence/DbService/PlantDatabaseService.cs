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
	}

	public interface IDatabaseService
	{
		Task<List<Plant>> GetPlants();
		Task AddPlant(Plant plant);
	}
}

