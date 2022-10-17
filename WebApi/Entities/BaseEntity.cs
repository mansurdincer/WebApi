namespace WebApi.Entities;

public class BaseEntity
{
    public int Id { get; set; }

    public int Author { get; set; }
    public DateTime CreatedDate { get; set; }

    public int Editor { get; set; }
    public DateTime? UpdatedDate { get; set; }

    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
    public BaseEntity()
    {
        CreatedDate = DateTime.Now;
    }
}
