namespace WebApi.Repositories;

public class RoleRepository : BaseRepository<Entities.Role>
{
    public RoleRepository(DataContext context) : base(context)
    {
    }
}

