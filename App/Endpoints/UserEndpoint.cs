namespace GreenThumb.Endpoints;
using GreenThumb.Model;
using GreenThumb.Persistence;

public class UserEndpoint : IEndpoint
{
     private IUserDatabaseService _service;
    public UserEndpoint(IUserDatabaseService service)
    {
        _service = service;
    }
    public void RegisterRoutes(IEndpointRouteBuilder app)
    {
       app.MapPut("add-user", async (User user) =>
        {
            await _service.AddUser(user);
        });

        app.MapGet("list-users", async() => 
        {
            return await _service.GetAllUsers();
        });

        app.MapGet("get-user", async(String username) => 
        {
            return await _service.GetUser(username);
        });
    }
}