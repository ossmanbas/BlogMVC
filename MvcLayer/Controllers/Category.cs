using Microsoft.AspNetCore.Mvc;

namespace MvcLayer.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
