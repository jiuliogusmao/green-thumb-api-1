namespace GreenThumb.Endpoints;

public interface IEndpoint
{
    void RegisterRoutes(IEndpointRouteBuilder app);
}