namespace WebApi.Entities;

public class Absenteeism : BaseEntity
{
    public int EmployeeId { get; set; }
    public virtual Employee Employee { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int AbsenteeismTypeId { get; set; }
    public virtual AbsenteeismType AbsenteeismType { get; set; }

}
