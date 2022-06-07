using Microsoft.AspNetCore.Mvc;

namespace MvcLayer.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
