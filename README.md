**ProductList API**

**Description**
The ProductList API is a RESTful API designed to manage a list of products. It provides endpoints for adding, retrieving, updating, and deleting products.

**Technologies Used**
- ASP.NET Core
- Entity Framework Core
- Microsoft SQL Server (or In-Memory Database for testing)
- Swagger for API documentation and testing

**Setup Instructions**
1. Clone this repository to your local machine.
2. Open the solution in Visual Studio or your preferred IDE.
3. Start the application.
4. Swagger will open in your browser with this URL: https://localhost:7177/swagger/index.html

**API Endpoints**

GET /api/products
Description: Retrieve all products.
Response: List of products in JSON format.

GET /api/products/{id}
Description: Retrieve a product by its ID.
Parameters:
id: Unique identifier of the product.
Response: Product details in JSON format.

POST /api/products
Description: Add a new product.
Request Body:
{
  "name": "Product Name",
  "description": "Product Description",
  "price": 10.99
}
Response: Added product details in JSON format.

PUT /api/products/{id}
Description: Update an existing product by its ID.
Parameters:
id: Unique identifier of the product to update.
Request Body:
{
  "name": "Updated Product Name",
  "description": "Updated Product Description",
  "price": 15.99
}
Response: Updated product details in JSON format.

DELETE /api/products/{id}
Description: Delete a product by its ID.
Parameters:
id: Unique identifier of the product to delete.
Response: Deleted product details in JSON format.

Created by: Joevert Cada
