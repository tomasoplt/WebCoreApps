using System.Collections.Generic;
using WebCoreApp.Services.Dto;

namespace WebCoreApp.Product.Services
{
    public class ProductService : IProductService
    {
        public List<ProductModelDto> GetProducts()
        {
            var products = new List<ProductModelDto>
            {
                new ProductModelDto { ProductID = 1, CategoryID = 1, Discontinued = false, ProductName = "Product 1", QuantityPerUnit = "1", UnitPrice = 11, UnitsInStock = 10, UnitsOnOrder = 1 },
                new ProductModelDto { ProductID = 2, CategoryID = 1, Discontinued = false, ProductName = "Product 2", QuantityPerUnit = "1", UnitPrice = 11, UnitsInStock = 10, UnitsOnOrder = 1 },
                new ProductModelDto { ProductID = 3, CategoryID = 1, Discontinued = false, ProductName = "Product 3", QuantityPerUnit = "1", UnitPrice = 11, UnitsInStock = 10, UnitsOnOrder = 1 }
            };
            return products;
        }
    }
}
