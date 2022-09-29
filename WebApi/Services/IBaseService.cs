namespace WebApi.Services;

public interface IBaseService<T, Dto> where T: BaseEntity, new()
{
    Task<Dto> GetByIdAsync(int id);
    Task<IReadOnlyList<Dto>> ListAllAsync();
    Task<Dto> AddAsync(Dto entity);
    Task UpdateAsync(Dto entity);
    Task DeleteAsync(Dto entity);
    Task<IList<Dto>> GetEntitiesWithCredentalAsync(Expression<Func<T, bool>> predicate);
}
