namespace WebApi.Models;

public class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public bool IsDeleted { get; set; }
    public BaseEntity()
    {
        CreatedDate = DateTime.Now;
    }    
}
