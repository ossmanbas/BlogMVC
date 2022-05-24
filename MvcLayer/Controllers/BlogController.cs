using Microsoft.AspNetCore.Mvc;

namespace MvcLayer.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
