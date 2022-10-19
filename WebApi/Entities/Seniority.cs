namespace WebApi.Entities;

public class Seniority : BaseEntity
{
    public string Name { get; set; }
    public float Multiplier { get; set; }
    public virtual ICollection<Employee> Employees { get; set; }

}
