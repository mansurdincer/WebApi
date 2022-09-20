namespace WebApi.Models;
public class Category : BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Product> Products { get; set; }

}
