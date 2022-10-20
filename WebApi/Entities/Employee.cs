namespace WebApi.Entities;

public class Employee : BaseEntity
{
    public string RegistrationNo { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime DateOfEmployment { get; set; }
    public DateTime? DateOfDismissal { get; set; }
    
    public string Email { get; set; }
    //public string Phone { get; set; }
    //public string Address { get; set; }
    //public string City { get; set; }
    //public string Country { get; set; }
    //public string ZipCode { get; set; }
    //public string Photo { get; set; }
    //public string Notes { get; set; }

    public int JobTitleId { get; set; }
    public virtual JobTitle? JobTitle { get; set; }

    public int? DepartmentId { get; set; }
    public virtual Department Department { get; set; }

    public int? SeniorityId { get; set; }
    public virtual Seniority Seniority { get; set; }

    public int? RankId { get; set; }
    public virtual Rank Rank { get; set; }
}
