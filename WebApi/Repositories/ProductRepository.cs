namespace WebApi.Repositories;

public class ProductRepository : BaseRepository<Entities.Product>
{
    public ProductRepository(DataContext context) : base(context)
    {
    }
}
