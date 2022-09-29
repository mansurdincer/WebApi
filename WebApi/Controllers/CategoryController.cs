namespace WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CategoryController : BaseController<Category,CategoryDto>
{
    private readonly ICacheService _cacheService;
    private readonly int _expirationSeconds;
    private readonly IMapper _mapper;
    public CategoryController(CategoryService categoryService) : base(categoryService)
    {
        _cacheService = categoryService.CacheService;
        _expirationSeconds = categoryService.ExpirationSeconds;
        _mapper = categoryService.Mapper;
    }    
}
