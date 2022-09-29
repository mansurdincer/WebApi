namespace WebApi.Repositories;

public interface IGenericRepository<T> where T : BaseEntity, new()
{
    Task<IList<T>> GetAllEntitiesAync();
    Task<T> GetEntityById(int id);
    Task<IList<T>> GetEntitiesWithCredential(Expression<Func<T, bool>> predicate);
    Task<T> Create(T entity);
    Task<T> Update(T entity);
    Task<bool> Delete(T entity);
    Task<bool> Delete(int id);    
}
