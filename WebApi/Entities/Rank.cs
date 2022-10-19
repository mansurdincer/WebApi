namespace WebApi.Entities;

public class Rank : BaseEntity
{
    public string Name { get; set; }
    public float Multiplier { get; set; }
    public virtual ICollection<Employee> Employees { get; set; }
}
