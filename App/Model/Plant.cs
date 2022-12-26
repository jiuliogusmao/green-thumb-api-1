namespace GreenThumb.Model;

public record Plant
{
    public string? Species { get; set; }
     public string Name()
    {
        string species = Species ?? "Planta não encontrada.";
        
        if(species != null)
        {
            Console.WriteLine(species);
        }

        return Species!;
    }
}
