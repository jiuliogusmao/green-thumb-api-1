namespace GreenThumb.Model;

public record Plant
{
    public int PlantId { get; set; }
    public string? Species { get; set; }
     public string Name()
    {
        return Species ?? "Planta não encontrada.";
    }
}
