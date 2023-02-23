using Microsoft.AspNetCore.Mvc;

namespace HealthLinkWebApp.Areas.Client.Controllers
{
    [Area("client")]
    [Route("home")]
    public class HomeController : Controller
    {
        [HttpGet("~/", Name = "client-home-index")]
        [HttpGet("index")]
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
