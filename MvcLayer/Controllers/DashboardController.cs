using Microsoft.AspNetCore.Mvc;

namespace MvcLayer.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
