using WebAPIWithMapsterDTOMapping.Model;
namespace WebAPIWithMapsterDTOMapping
{
    public class ProductService
    {
        public IEnumerable<Product> GetProducts() => products;
        public Product AddProduct(Product product)
        { products.Add(product); return product; }

        // In-memory data store for demonstration purposes
        private static readonly List<Product> products =
    [
        new Product
        {
            Id = 1,
            Name = "Sample Product",
            Description = "This is a sample product",
            Price = 19.99m,
            Category = "Category1",
            StockQuantity = 100,
            CreatedDate = DateTime.Now,
            ModifiedDate = DateTime.Now
        },
        new Product
        {
            Id = 2,
            Name = "Sample Product 2",
            Description = "This is a sample product 2",
            Price = 19.99m,
            Category = "Category2",
            StockQuantity = 100,
            CreatedDate = DateTime.Now,
            ModifiedDate = DateTime.Now
        },

         new Product
        {
            Id = 3,
            Name = "Sample Product 3",
            Description = "This is a sample product 3",
            Price = 19.99m,
            Category = "Category3",
            StockQuantity = 100,
            CreatedDate = DateTime.Now,
            ModifiedDate = DateTime.Now
        }

    ];

       
    }
}
