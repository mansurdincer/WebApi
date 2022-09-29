namespace WebApi.Repositories;

public class CategoryRepostitory : BaseRepository<Entities.Category>
{
    public CategoryRepostitory(DataContext context) : base(context)
    {
    }    
}
