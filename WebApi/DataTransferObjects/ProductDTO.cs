namespace WebApi.DataTransferObjects;
public class ProductDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Cost { get; set; }
    public int Stock { get; set; }
    public int CategoryId { get; set; }
}
