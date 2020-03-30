using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using WebCoreApp.Product.Services;
using WebCoreApp.Services.Dto;

namespace WebCoreAppRazorPages
{
    public class GridWithEditPageDetailModel : PageModel
    {
        public List<DepartmentDto> Departments { get; set; }

        private readonly IDepartmentService _departmentService;

        private readonly ILogger<BasicGridModel> _logger;

        public GridWithEditPageDetailModel(IDepartmentService departmentService, ILogger<BasicGridModel> logger)
        {
            _logger = logger;
            _departmentService = departmentService;
        }

        public void OnGet()
        {
            _logger.LogInformation($"Getting Products");
            Departments = _departmentService.GetDepartments();
        }
    }
}