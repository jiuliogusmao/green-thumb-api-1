namespace GreenThumb.Model;

public record Plant
{
    public int PlantId { get; set; }
    public string? Nickname { get; set; }
    public Species? Species { get; set; }
}
