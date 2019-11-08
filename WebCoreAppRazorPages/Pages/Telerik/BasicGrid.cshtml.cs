using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using WebCoreApp.Product.Services;
using WebCoreApp.Services.Dto;

namespace WebCoreAppRazorPages
{
    public class BasicGridModel : PageModel
    {
        public List<ProductModelDto> Products { get; set; }

        private readonly IProductService _productService;

        private readonly ILogger<BasicGridModel> _logger;

        public BasicGridModel(IProductService productService, ILogger<BasicGridModel> logger)
        {
            _logger = logger;
            _productService = productService;
        }

        public void OnGet()
        {
            _logger.LogInformation($"Getting Products");
            Products = _productService.GetProducts();
        }
    }
}