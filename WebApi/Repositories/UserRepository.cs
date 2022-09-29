namespace WebApi.Repositories;

public class UserRepository : BaseRepository<Entities.User>
{
    public UserRepository(DataContext context) : base(context)
    {
    }
}
