namespace GreenThumb.Model;

public record Species
{
    public Species()
    {
        Cares = new List<Care>();
    }
    public int SpeciesId { get; set; }
    public string? Name{get; set;}

    public List<Care> Cares { get; set; }
}