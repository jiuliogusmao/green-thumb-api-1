using GreenThumb.Model;
namespace GreenThumb.Persistence
{

    public class UserDatabaseService : IUserDatabaseService
    {
        private readonly UserDbContext _context;

        public UserDatabaseService (UserDatabaseService context)
        {
            _context = context;
        }
        public async Task AddUser(User user)
        {
           await _context.Users.AddAsync(user);
           await _context.SaveChangesAsync();
        }

        public async Task<User> GetUser(String username)
        {
            var users = await _context.Users
                .Where(u => u.Username == username).ToListAsync();
                return users.Count > 0 ? users[0] : new User {}; 
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }
    }

    public interface IUserDatabaseService
{
    Task<List<User>> GetAllUsers();
		Task AddUser(User user);
        Task<User> GetUser(String username); 
}

}