using Net.Core.Application.Service;
using System.Collections.Generic;
using WebCoreApp.Services.Dto;

namespace WebCoreApp.Product.Services
{
    public interface IProductService : IApplicationService
    {
        List<ProductModelDto> GetProducts();
    }
}