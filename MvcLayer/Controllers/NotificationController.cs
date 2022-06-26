using Microsoft.AspNetCore.Mvc;

namespace MvcLayer.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
