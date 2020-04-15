using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebCoreAppMvc.Controllers
{
    public class TablesController : Controller
    {
        private readonly ILogger<TablesController> _logger;

        public TablesController(ILogger<TablesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Normal()
        {
            return View();
        }

        public IActionResult Datatables()
        {
            return View();
        }

        public IActionResult Jqgrid()
        {
            return View();
        }
    }
}
