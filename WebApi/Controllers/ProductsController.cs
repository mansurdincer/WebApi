﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Cache;
using WebApi.Data;
using WebApi.Models;


namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class ProductsController : ControllerBase
    {
        private readonly DbContextClass _context;
        private readonly ICacheService _cacheService;
        private readonly int _expirationSeconds;
        public ProductsController(DbContextClass context, ICacheService cacheService)
        {
            _context = context;
            _cacheService = cacheService;
            _expirationSeconds = int.Parse(ConfigurationManager.AppSetting["RedisCacheExpirationSeconds"]);

        }

        // GET: api/Products
        [HttpGet]
        
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            var productCache = _cacheService.GetData<List<Product>>("Products");
            if (productCache == null)
            {
                var products = await _context.Products.ToListAsync();

                if (products != null)
                {
                    productCache = products;
                    _cacheService.SetData("Products", products, DateTimeOffset.Now.AddSeconds(_expirationSeconds));
                }
                
                return products;

            }

            return productCache;

            //if (_context.Products == null)
            //{
            //    return NotFound();
            //}
            //return await _context.Products.ToListAsync();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var productCache = _cacheService.GetData<Product>("Product" + id);
            if (productCache == null)
            {
                var product = await _context.Products.FindAsync(id);

                if (product == null)
                {
                    return NoContent();
                }

                productCache = product;
                _cacheService.SetData("Product" + id, product, DateTimeOffset.Now.AddSeconds(_expirationSeconds));

                return product;
            }
            return productCache;


            //if (_context.Products == null)
            //{
            //    return NotFound();
            //}
            //var product = await _context.Products.FindAsync(id);

            //if (product == null)
            //{
            //    return NotFound();
            //}

            //return product;
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                _cacheService.SetData("Product" + product.Id, product, DateTimeOffset.Now.AddSeconds(_expirationSeconds));                
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
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

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            if (_context.Products == null)
            {
                return Problem("Entity set 'DbContextClass.Products'  is null.");
            }
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            _cacheService.SetData("Product" + product.Id, product, DateTimeOffset.Now.AddSeconds(_expirationSeconds));            

            return CreatedAtAction("GetProduct", new { id = product.Id }, product);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            if (_context.Products == null)
            {
                return NotFound();
            }
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            _cacheService.RemoveData("Product");
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductExists(int id)
        {
            return (_context.Products?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
