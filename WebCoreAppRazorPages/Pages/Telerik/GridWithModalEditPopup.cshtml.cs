using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebCoreApp.Product.Services;
using WebCoreApp.Services.Dto;

namespace WebCoreAppRazorPages
{
    public class GridWithModalEditPopup : PageModel
    {
        public int Id { get; set; }

        private readonly IDepartmentService _departmentService;

        private readonly ILogger<BasicGridModel> _logger;

        [BindProperty(SupportsGet = true)]
        public DepartmentDto Department { get; set; }

        public GridWithModalEditPopup(IDepartmentService departmentService, ILogger<BasicGridModel> logger)
        {
            _logger = logger;
            _departmentService = departmentService;
        }

        public void OnGet(int id)
        {
            Department = _departmentService.GetDepartment(id);
        }

        public void OnPostPopupDetail()
        {
            if (ModelState.IsValid)
            {
            }
        }
    }
}