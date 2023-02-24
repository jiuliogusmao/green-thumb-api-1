namespace GreenThumb.Model;

public record Species
{
public string? Name{get; set;}

public List<ICare>? Cares { get; set; }
}