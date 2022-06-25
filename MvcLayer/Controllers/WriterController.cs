using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MvcLayer.Controllers
{
    
    public class WriterController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        

        public IActionResult WriterProfile()
        {
            return View();
        }

         [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }
         [AllowAnonymous]
        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }
    }
}
