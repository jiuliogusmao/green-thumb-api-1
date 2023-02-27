using GreenThumb.Model;

namespace GreenThumb.Persistence;

public class PlantDbContext : DbContext
{
	public PlantDbContext(DbContextOptions<PlantDbContext> options) : base(options)
	{
		Database.EnsureCreated();
	}
	public DbSet<Plant> Plants { get; set; } 
	public DbSet<Species> Species { get; set; }
	public DbSet<Care> Cares { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

	modelBuilder.Entity<Species>(entity =>
    {
        entity.HasMany(s => s.Cares)
              .WithOne()
              .HasForeignKey(c => c.SpeciesId)
              .IsRequired();
    });

}

}

