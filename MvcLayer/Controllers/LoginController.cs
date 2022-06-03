using Microsoft.AspNetCore.Mvc;

namespace MvcLayer.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
