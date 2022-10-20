using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.DTOs;

namespace WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class RankController : ControllerBase
{
    private readonly DataContext _context;
    private readonly ICacheService _cacheService;
    private readonly int _expirationSeconds;
    private readonly IMapper _mapper;
    public RankController(DataContext context, ICacheService cacheService, IMapper mapper)
    {
        _context = context;
        _cacheService = cacheService;
        _expirationSeconds = int.Parse(ConfigurationManager.AppSetting["RedisCacheExpirationSeconds"]);
        _mapper = mapper;

    }

    // GET: api/Rank
    [HttpGet]
    public async Task<ActionResult<IEnumerable<RankDto>>> GetRanks()
    {
        var rankCache = _cacheService.GetData<List<RankDto>>("Ranks");
        //int a = 0;
        //int s = 9 / a;

        if (rankCache == null)
        {
            var ranks = await _context.Ranks.Select(rank => _mapper.Map<RankDto>(rank)).ToListAsync();

            if (ranks != null)
            {
                rankCache = ranks;
                _cacheService.SetData("Ranks", ranks, DateTimeOffset.Now.AddSeconds(_expirationSeconds));
            }

            return ranks;
        }

        return rankCache;
    }

    // GET: api/Rank/5
    [HttpGet("{id}")]
    public async Task<ActionResult<RankDto>> GetRank(int id)
    {
        var rankCache = _cacheService.GetData<RankDto>("Rank" + id);
        if (rankCache == null)
        {
            //var rank = await _context.Ranks.FindAsync(id);

            var rank = await _context.Ranks.Where(r => r.Id == id)
                //.Take(10).Skip(20)
                //.Count()
                //.OrderBy(r => r.Id)
                //.MaxAsync(r => r.Id)
                .Select(rank => _mapper.Map<RankDto>(rank))
                .FirstOrDefaultAsync();

            if (rank == null)
            {
                return NotFound();
            }

            rankCache = rank;
            _cacheService.SetData("Rank" + id, rank, DateTimeOffset.Now.AddSeconds(_expirationSeconds));
        }

        return rankCache;
    }

    // PUT: api/Rank/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutRank(int id, RankDto rankDto)
    {
        if (id != rankDto.Id)
        {
            return BadRequest();
        }

        _context.Entry(_mapper.Map<Rank>(rankDto)).State = EntityState.Modified;
        try
        {
            _cacheService.SetData("Rank" + rankDto.Id, rankDto, DateTimeOffset.Now.AddSeconds(_expirationSeconds));
            await _context.SaveChangesAsync();

        }
        catch (DbUpdateConcurrencyException)
        {
            if (!RankExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();


    }

    private bool RankExists(int id)
    {
        return _context.Ranks.Any(e => e.Id == id);
    }
}
