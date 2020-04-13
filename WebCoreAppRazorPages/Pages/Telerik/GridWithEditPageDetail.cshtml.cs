using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebCoreApp.Product.Services;
using WebCoreApp.Services.Dto;

namespace WebCoreAppRazorPages
{
    public class GridWithEditPageDetailModel : PageModel
    {
        [BindProperty]
        public DepartmentDto DepartmentDetail { get; set; }

        private readonly IDepartmentService _departmentService;

        private readonly ILogger<BasicGridModel> _logger;

        public GridWithEditPageDetailModel(IDepartmentService departmentService, ILogger<BasicGridModel> logger)
        {
            _logger = logger;
            _departmentService = departmentService;
        }

        public void OnGet(int id)
        {
            _logger.LogInformation($"Getting Products");
            DepartmentDetail = _departmentService.GetDepartment(id);
        }

        public IActionResult OnPost()
        {
            _logger.LogInformation($"Setting Products");

            if (ModelState.IsValid)
            {
                // Get object from database
                var dbObject = _departmentService.GetDepartment(DepartmentDetail.DepartmentID);
                // Update fields
                dbObject.Name = DepartmentDetail.Name;
                // Save back to database
                _departmentService.Update(dbObject);

                return RedirectToPage("/Telerik/GridWithEditPage");
            }
            
            return Page();
        }
    }
}