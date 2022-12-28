namespace GreenThumb.Model;

public record Plant
{
    public int PlantId { get; set; }
    public string? Species { get; set; }
     public string Name()
    {

        string species = Species ?? "Planta não encontrada.";
        
        if(Species != null)
        {
            Console.WriteLine(Species);
        }

        return species;

        
    }
}
