using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebCoreAppRazorPages
{
    public class BasicGridDepartmentDetailModel : PageModel
    {
        public int Id { get; set; }
        
        public void OnGet(int id)
        {
            Id = id;
        }
    }
}