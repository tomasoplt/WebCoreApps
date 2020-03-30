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
    public class GridWithEditPageModel : PageModel
    {
        public List<DepartmentDto> Departments { get; set; }

        private readonly IDepartmentService _departmentService;

        private readonly ILogger<BasicGridModel> _logger;

        public GridWithEditPageModel(IDepartmentService departmentService, ILogger<BasicGridModel> logger)
        {
            _logger = logger;
            _departmentService = departmentService;
        }

        public void OnGet()
        {
        }

        public JsonResult OnPostRead([DataSourceRequest] DataSourceRequest request)
        {
            _logger.LogInformation($"Getting Departments");

            var departments = _departmentService.GetDepartments();
            return new JsonResult(departments.ToDataSourceResult(request));
        }

        public void DepartmentDetail(int id)
        {

        }
    }
}