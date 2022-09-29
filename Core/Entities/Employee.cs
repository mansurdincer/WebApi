namespace WebApi.Entities;

public class Employee : BaseEntity
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string ZipCode { get; set; }
    public string Photo { get; set; }
    public string Notes { get; set; }

    public int JobTitleId { get; set; }
    public virtual JobTitle? JobTitle { get; set; }

    public int? DepartmentId { get; set; }
    public virtual Department Department { get; set; }
}
