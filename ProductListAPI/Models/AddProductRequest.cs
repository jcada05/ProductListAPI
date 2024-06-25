namespace ProductListAPI.Models
{
    // Description: Represents the request model for adding a new product.
    public class AddProductRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
