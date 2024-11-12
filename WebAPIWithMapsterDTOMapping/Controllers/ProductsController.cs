using Mapster;
using Microsoft.AspNetCore.Mvc;
using WebAPIWithMapsterDTOMapping.DTOs;
using WebAPIWithMapsterDTOMapping.Model;
namespace WebAPIWithMapsterDTOMapping.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController(ProductService productService) : ControllerBase
    {
        [HttpPost]
        public ActionResult<CreateProductDTO> Create(CreateProductDTO product)
        {
            //var _product = new Product
            //{
            //    Id = productService.GetProducts().Count() + 1,
            //    Name = product.Name,
            //    Description = product.Description,
            //    Price = product.Price,
            //    Category = product.Category,
            //    StockQuantity = product.StockQuantity
            //};

            var _product = product.Adapt<Product>();
            productService.AddProduct(_product);
            return Ok(product);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            var products = productService.GetProducts();

            //var _products = new List<GetProductDTO>();
            //foreach (var product in products)
            //{
            //    _products.Add(new GetProductDTO
            //    {
            //        Id = product.Id,
            //        Name = product.Name,
            //        Description = product.Description,
            //        Price = product.Price,
            //        Category = product.Category,
            //        StockQuantity = product.StockQuantity,
            //        CreatedDate = product.CreatedDate,
            //        ModifiedDate = product.ModifiedDate
            //    });
            //}
            var _products = products.Adapt<IEnumerable<GetProductDTO>>();
            return Ok(_products);

        }

        [HttpGet("{id}")]
        public ActionResult<GetProductDTO> GetProduct(int id)
        {
            var product = productService.GetProducts().FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();

            // Manual mapping from Product to ProductDto
            //var productDto = new GetProductDTO
            //{
            //    Id = product.Id,
            //    Name = product.Name,
            //    Description = product.Description,
            //    Price = product.Price,
            //    Category = product.Category,
            //    StockQuantity = product.StockQuantity,
            //    CreatedDate = product.CreatedDate,
            //    ModifiedDate = product.ModifiedDate
            //};

            var _product = product.Adapt<GetProductDTO>();
            return Ok(_product);
        }
    }

}
