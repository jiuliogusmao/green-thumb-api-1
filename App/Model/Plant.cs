namespace GreenThumb.Model;

public record Plant
{
    public string? Species { get; set; }
    public string Name()
    {
        throw new NotImplementedException();
    }
}