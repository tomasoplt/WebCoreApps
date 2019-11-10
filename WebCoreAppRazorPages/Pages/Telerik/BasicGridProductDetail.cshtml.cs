using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebCoreAppRazorPages
{
    public class BasicGridProductDetailModel : PageModel
    {
        public int Id { get; set; }
        
        public void OnGet(int id)
        {
            Id = id;
        }
    }
}