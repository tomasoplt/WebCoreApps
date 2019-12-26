using Net.Core.Application.Service;
using System.Collections.Generic;
using WebCoreApp.EF.Models;
using WebCoreApp.Services.Dto;

namespace WebCoreApp.Product.Services
{
    public interface IDepartmentService : IApplicationService
    {
        List<DepartmentDto> GetDepartments();
        DepartmentDto GetDepartment(int id);
    }
}