namespace WebApi.Services;

public class CategoryService : BaseService<Category, CategoryDto>
{

    private readonly ICacheService _cacheService;
    private readonly int _expirationSeconds;
    private readonly IMapper _mapper;    
    
    public CategoryService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
    {
        _mapper = mapper;
    }

    public override CategoryDto ConvertToDto(Category category)
    {
        return _mapper.Map<CategoryDto>(category);
    }

    public override Category ConvertToEntity(CategoryDto dto)
    {
        return _mapper.Map<Category>(dto);
    }


    //public async Task<IReadOnlyList<CategoryDto>> GetCategoriesWithProductsAsync()
    //{
    //    var categories = await _unitOfWork.Repository<Category>().GetCategoriesWithProductsAsync();
    //    return _mapper.Map<IReadOnlyList<CategoryDto>>(categories);
    //}
}

