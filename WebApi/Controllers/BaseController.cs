using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BaseController<T, Dto> : ControllerBase where T : BaseEntity, new()
{
    private readonly DataContext _context;
    private readonly ICacheService _cacheService;
    private readonly int _expirationSeconds;
    private readonly IMapper _mapper;
    
    public BaseController(DataContext context, ICacheService cacheService, IMapper mapper)
    {
        _context = context;
        _cacheService = cacheService;
        _expirationSeconds = int.Parse(ConfigurationManager.AppSetting["RedisCacheExpirationSeconds"]);
        _mapper = mapper;
    }

    //// GET: api/<BaseController>
    //[HttpGet]
    //public async Task<ActionResult<IEnumerable<Dto>>> Get()
    //{
    //    var cache = _cacheService.GetData<List<Dto>>("Products");

    //    if (cache == null)
    //    {
    //        var products = await _context.Set<T>().Select(slct => _mapper.Map<Dto>(slct)).ToListAsync();

    //        if (products != null)
    //        {
    //            cache = products;
    //            _cacheService.SetData("Products", products, DateTimeOffset.Now.AddSeconds(_expirationSeconds));
    //        }

    //        return products;
    //    }

    //    return cache;
    //}

    //// GET api/<BaseController>/5
    //[HttpGet("{id}")]
    //public async Task<ActionResult<Dto>> Get(int id)
    //{
    //    var cache = _cacheService.GetData<Dto>("Product" + id);
    //    if (cache == null)
    //    {
    //        //var product = await _context.Products.FindAsync(id);

    //        var product = await _context.Set<T>().Where(p => p.Id == id)
    //            //.Take(10).Skip(20)
    //            //.Count()
    //            //.OrderBy(p => p.Id)
    //            //.MaxAsync(p => p.Id)
    //            .Select(product => _mapper.Map<Dto>(product))
    //            .FirstOrDefaultAsync();

    //        if (product == null)
    //        {
    //            return NotFound();
    //        }

    //        cache = product;
    //        _cacheService.SetData("Product" + id, product, DateTimeOffset.Now.AddSeconds(_expirationSeconds));

    //        return product;
    //    }

    //    return cache;
    //}

    //// POST api/<BaseController>
    //[HttpPost]
    //public async Task<ActionResult<Dto>> Post([FromBody] Dto value)
    //{
    //    var entity = _mapper.Map<T>(value);
    //    _context.Set<T>().Add(entity);
    //    await _context.SaveChangesAsync();

    //    var dto = _mapper.Map<Dto>(entity);

    //    return CreatedAtAction("Get", new { id = entity.Id }, dto);
    //}


}
