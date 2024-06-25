using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductListAPI.Data;
using ProductListAPI.Models;

namespace ProductListAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly ProductListAPIDbContext dbContext;

        public ProductsController(ProductListAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            // Return all products from the database
            return Ok(await dbContext.Products.ToListAsync());
        }

        // GET: api/Products/{id}
        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetProduct([FromRoute] Guid id)
        {
            // Retrieve a product by its ID
            var product = await dbContext.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound("Product not found!");
            }

            return Ok(product);
        }

        // POST: api/Products
        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductRequest addProductRequest)
        {
            // Add a new product to the database
            var product = new Product()
            {
                Id = Guid.NewGuid(),
                Name = addProductRequest.Name,
                Description = addProductRequest.Description,
                Price = addProductRequest.Price,
            };

            await dbContext.Products.AddAsync(product);
            await dbContext.SaveChangesAsync();

            return Ok(product);
        }

        // PUT: api/Products/{id}
        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateProduct([FromRoute] Guid id, UpdateProductRequest updateProductRequest)
        {
            // Update an existing product
            var product = await dbContext.Products.FindAsync(id);

            if (product != null)
            {
                product.Name = updateProductRequest.Name;
                product.Description = updateProductRequest.Description;
                product.Price = updateProductRequest.Price;

                await dbContext.SaveChangesAsync();

                return Ok(product);
            }

            return NotFound();
        }

        // DELETE: api/Products/{id}
        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] Guid id)
        {
            // Delete a product by its ID
            var product = await dbContext.Products.FindAsync(id);

            if (product != null)
            {
                dbContext.Remove(product);
                await dbContext.SaveChangesAsync();
                return Ok(product);
            }

            return NotFound();
        }
    }
}
