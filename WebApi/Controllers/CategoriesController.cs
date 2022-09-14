
namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly DbContextClass _context;

        public CategoriesController(DbContextClass context)
        {
            _context = context;
        }

        // GET: api/Categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDTO>>> GetCategoryDTO()
        {
          if (_context.CategoryDTO == null)
          {
              return NotFound();
          }
            return await _context.CategoryDTO.ToListAsync();
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryDTO>> GetCategoryDTO(int id)
        {
          if (_context.CategoryDTO == null)
          {
              return NotFound();
          }
            var categoryDTO = await _context.CategoryDTO.FindAsync(id);

            if (categoryDTO == null)
            {
                return NotFound();
            }

            return categoryDTO;
        }

        // PUT: api/Categories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategoryDTO(int id, CategoryDTO categoryDTO)
        {
            if (id != categoryDTO.Id)
            {
                return BadRequest();
            }

            _context.Entry(categoryDTO).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryDTOExists(id))
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

        // POST: api/Categories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CategoryDTO>> PostCategoryDTO(CategoryDTO categoryDTO)
        {
          if (_context.CategoryDTO == null)
          {
              return Problem("Entity set 'DbContextClass.CategoryDTO'  is null.");
          }
            _context.CategoryDTO.Add(categoryDTO);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategoryDTO", new { id = categoryDTO.Id }, categoryDTO);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategoryDTO(int id)
        {
            if (_context.CategoryDTO == null)
            {
                return NotFound();
            }
            var categoryDTO = await _context.CategoryDTO.FindAsync(id);
            if (categoryDTO == null)
            {
                return NotFound();
            }

            _context.CategoryDTO.Remove(categoryDTO);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CategoryDTOExists(int id)
        {
            return (_context.CategoryDTO?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
