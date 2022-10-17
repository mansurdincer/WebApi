namespace WebApi.Entities;

public class AbsenteeismType : BaseEntity
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public virtual ICollection<Absenteeism> Absenteeisms { get; set; }
}