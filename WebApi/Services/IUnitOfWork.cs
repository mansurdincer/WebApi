namespace WebApi.Services;

public interface IUnitOfWork : IDisposable
{    
    IGenericRepository<T> Repository<T>() where T : BaseEntity, new();
    Task<int> CompleteAsync();
    
}