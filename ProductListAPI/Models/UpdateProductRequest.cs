namespace ProductListAPI.Models
{
    // Description: Represents the request model for Updating a new product.
    public class UpdateProductRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
