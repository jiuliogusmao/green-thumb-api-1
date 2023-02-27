using System.ComponentModel.DataAnnotations.Schema;

namespace GreenThumb.Model;
public record Care
{
    public int CareId { get; set; }
    public Levels Level {get; set;}
    public CareTypes CareType { get; set; }
    public virtual int SpeciesId { get; set; }
}
