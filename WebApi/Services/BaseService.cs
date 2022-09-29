namespace WebApi.Services;

public abstract class BaseService<T, Dto> : IBaseService<T, Dto> where T : BaseEntity, new()
{
    protected readonly IUnitOfWork _unitOfWork;
    protected readonly IMapper _mapper;

    public BaseService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public abstract T ConvertToEntity(Dto dto);
    public abstract Dto ConvertToDto(T dbo);

    public virtual async Task<Dto> GetByIdAsync(int id)
    {
        var entity = await _unitOfWork.Repository<T>().GetEntityById(id);
        return _mapper.Map<Dto>(entity);
    }

    public virtual async Task<IReadOnlyList<Dto>> ListAllAsync()
    {
        var entities = await _unitOfWork.Repository<T>().GetAllEntitiesAync();
        return _mapper.Map<IReadOnlyList<Dto>>(entities);
    }

    public virtual async Task<Dto> AddAsync(Dto entity)
    {
        var entityToAdd = _mapper.Map<T>(entity);
        await _unitOfWork.Repository<T>().Create(entityToAdd);
        await _unitOfWork.CompleteAsync();
        return _mapper.Map<Dto>(entityToAdd);
    }

    public virtual async Task UpdateAsync(Dto entity)
    {
        var entityToUpdate = _mapper.Map<T>(entity);
        _unitOfWork.Repository<T>().Update(entityToUpdate);
        await _unitOfWork.CompleteAsync();
    }

    public virtual async Task DeleteAsync(Dto entity)
    {
        var entityToDelete = _mapper.Map<T>(entity);
        _unitOfWork.Repository<T>().Delete(entityToDelete);
        await _unitOfWork.CompleteAsync();
    }

    public virtual async Task<IList<Dto>> GetEntitiesWithCredentalAsync(Expression<Func<T, bool>> predicate)
    {
        var entities = await _unitOfWork.Repository<T>().GetEntitiesWithCredential(predicate);
        return _mapper.Map<IList<Dto>>(entities);
    }
}

