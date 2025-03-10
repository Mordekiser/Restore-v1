using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")] //https://localhost:7233/api/products
    [ApiController]
    public class ProductsController(StoreContext context) : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts() {
            return await context.Products.ToListAsync();
        }

        [HttpGet("{id}")] // api/Products/Id
        public async Task<ActionResult<Product>> GetProduct(int id){
            
            var product = await context.Products.FindAsync(id);

            if (product == null) return NotFound();

            return product;
        }
    }
}
