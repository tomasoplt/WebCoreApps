using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebCoreApp.Product.Services;

namespace WebCoreAppRazorPages
{
    public class GridWithModalEditPopup : PageModel
    {
        public int Id { get; set; }

        private readonly IDepartmentService _departmentService;

        private readonly ILogger<BasicGridModel> _logger;

        [BindProperty(SupportsGet = true)]
        public string txtDepartmentID { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string txtDepartmentName { get; set; }

        public GridWithModalEditPopup(IDepartmentService departmentService, ILogger<BasicGridModel> logger)
        {
            _logger = logger;
            _departmentService = departmentService;
        }

        public void OnGet(int id)
        {
            var department = _departmentService.GetDepartment(id);
            txtDepartmentID = department.DepartmentID.ToString();
            txtDepartmentName = department.Name;
        }
    }
}