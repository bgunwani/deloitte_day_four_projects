using coreWebAPIServerProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace coreWebAPIServerProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ApplicationDBContext _context;
        public ProductController(ApplicationDBContext context)
        {
            _context = context;
        }

        // Request Url: http://localhost:5183/api/product
        [HttpGet]
        public async Task<ActionResult<IList<Product>>> GetProducts()
        {
            if (_context.Products == null)
                return NotFound();
            return await _context.Products.ToListAsync();
        }


        // Request Url: http://localhost:5183/api/product/101
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            if (_context.Products == null)
                return NotFound();
            var product = await _context.Products.FindAsync(id);
            if (product == null)
                return NotFound();
            return product;
        }


        [HttpGet("{id}/{name}")]
        public Product? GetProduct(int id, string name)
        {
            return _context.Products.Where(x => x.ProductId == id && x.ProductName == name).SingleOrDefault();
        }


        [HttpPost]
        public async Task<ActionResult> PostProduct([FromBody]Product product)
        {
            if (_context.Products == null)
                return Problem("Products Entity doesn't exist.");
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProduct), new { id = product.ProductId}, product);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> PutProduct(int id, [FromBody]Product product)
        {
            if (id != product.ProductId)
                return BadRequest();
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduct(int id)
        {
            if (_context.Products == null)
                return Problem("Products Entity doesn't exist.");
            var product = await _context.Products.FindAsync(id);
            if (product == null)
                return NotFound();
            _context.Products.Remove(product);
            _context.SaveChanges();
            return NoContent();
        }


    }
}
