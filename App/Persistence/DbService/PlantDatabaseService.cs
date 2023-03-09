using GreenThumb.Model;
using Microsoft.EntityFrameworkCore;

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
            var existingSpecies = _context.Species.Find(plant.Species?.SpeciesId);
            
            var newPlant = new Plant
            {
                Nickname = plant.Nickname,
                Species = existingSpecies ?? null
            };

            _context.Attach(existingSpecies);
            await _context.Plants.AddAsync(newPlant);
			await _context.SaveChangesAsync();
		}
		public async Task<Plant> GetPlant(int plantId)
		{
            var plants = await _context.Plants
                    .Where(p => p.PlantId == plantId).ToListAsync();
            return plants.Count > 0 ? plants[0] : new Plant {};
        }
		public async Task DeletePlant(int plantId)
		{
            var plant = await _context.Plants.FindAsync(plantId);
            if(plant != null){
                _context.Plants.Remove(plant);
                await _context.SaveChangesAsync();
            }
        }
		public async Task AddSpecies(Species species)
		{
            await _context.Species.AddAsync(species);
            await _context.SaveChangesAsync();
        }
		public async Task<List<Species>> GetSpecies()
		{
            return await _context.Species
				.Include(c => c.Cares)
			.ToListAsync();
        }
	}

	public interface IDatabaseService
	{
		Task<List<Plant>> GetPlants();
		Task AddPlant(Plant plant);
        Task<Plant> GetPlant(int plantId);
        Task AddSpecies(Species species);
        Task<List<Species>> GetSpecies();
    }
}

