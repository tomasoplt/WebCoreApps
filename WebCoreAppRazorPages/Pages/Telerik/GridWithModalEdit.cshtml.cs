using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using WebCoreApp.Product.Services;
using WebCoreApp.Services.Dto;

namespace WebCoreAppRazorPages
{
    public class GridWithModalEdit : PageModel
    {
        private readonly IDepartmentService _departmentService;

        private readonly ILogger<GridWithModalEdit> _logger;

        public GridWithModalEdit(IDepartmentService departmentService, ILogger<GridWithModalEdit> logger)
        {
            _logger = logger;
            _departmentService = departmentService;
        }

        public void OnGet()
        {
            _logger.LogInformation($"Getting Products");
        }

        public JsonResult OnPostRead([DataSourceRequest] DataSourceRequest request)
        {
            var departments = _departmentService.GetDepartments();
            return new JsonResult(departments.ToDataSourceResult(request));
        }
      
    }
}