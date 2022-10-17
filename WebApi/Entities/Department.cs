namespace WebApi.Entities;

public class Department : BaseEntity
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public int? ParentId { get; set; }
    public virtual Department Parent { get; set; }
    public virtual ICollection<Department> Children { get; set; }
    public virtual ICollection<Employee> Employees { get; set; }

}
