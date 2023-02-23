using Microsoft.AspNetCore.Mvc;

namespace HealthLinkWebApp.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/analyticts")]
    public class AnalytictsController : Controller
    {
        [HttpGet("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
