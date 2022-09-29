namespace WebApi.Repositories;

public class BaseRepository<TEntity,TContext> : IGenericRepository<TEntity> 
    where TEntity : BaseEntity, new()
    where TContext : DbContext, new()
{
    protected readonly DataContext Context;
    protected readonly DbSet<TEntity> DbSet;

    public BaseRepository(DataContext context)
    {
        Context = context;
        DbSet = Context.Set<TEntity>();
    }

    public async Task<IList<TEntity>> GetAllEntitiesAync()
    {
        return await DbSet.ToListAsync();
    }

    public async Task<TEntity> GetEntityById(int id)
    {
        return await DbSet.FindAsync(id);
    }

    public async Task<IList<TEntity>> GetEntitiesWithCredential(Expression<Func<TEntity, bool>> predicate)
    {
        return await DbSet.Where(predicate).ToListAsync();
    }

    public async Task<TEntity> Create(TEntity entity)
    {
        await DbSet.AddAsync(entity);
        await Context.SaveChangesAsync();
        return entity;
    }

    public async Task<TEntity> Update(TEntity entity)
    {
        DbSet.Update(entity);
        await Context.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> Delete(TEntity entity)
    {
        DbSet.Remove(entity);
        return await Context.SaveChangesAsync() > 0;
    }

    public async Task<bool> Delete(int id)
    {
        var entity = await DbSet.FindAsync(id);
        if (entity == null)
        {
            return false;
        }

        DbSet.Remove(entity);
        return await Context.SaveChangesAsync() > 0;
    }

   
}

