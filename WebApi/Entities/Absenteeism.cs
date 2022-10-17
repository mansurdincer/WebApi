namespace WebApi.Entities;

public class Absenteeism : BaseEntity
{
    public int EmployeeId { get; set; }
    public virtual Employee Employee { get; set; }
    public DateOnly DateFrom { get; set; }
    public DateOnly DateTo { get; set; }
    public int AbsenteeismTypeId { get; set; }
    public virtual AbsenteeismType AbsenteeismType { get; set; }
    public string? Description { get; set; }

}
