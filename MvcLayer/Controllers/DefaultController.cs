using Microsoft.AspNetCore.Mvc;

namespace MvcLayer.Controllers
{
    public class DefaultController : Controller
    {
        public PartialViewResult Partial1()
        {
            return PartialView();
        }
    }
}
