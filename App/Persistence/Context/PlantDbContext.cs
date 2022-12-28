using GreenThumb.Model;

namespace GreenThumb.Persistence;

public class PlantDbContext : DbContext
{
	public PlantDbContext(DbContextOptions<PlantDbContext> options) : base(options)
	{
		Database.EnsureCreated();
	}
	public DbSet<Plant> Plants { get; set; } = default!;
}

