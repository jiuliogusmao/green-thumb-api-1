using GreenThumb.Model;
namespace GreenThumb.Persistence;

public class UserDbContext : DbContext
{
    public UserDbContext (DbContextOptions<UserDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<User> Users {get; set;} = default!;

    public static implicit operator UserDbContext(UserDatabaseService v)
    {
        throw new NotImplementedException();
    }
}