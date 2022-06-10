using Microsoft.AspNetCore.Mvc;

namespace MvcLayer.ViewComponents.Writer
{
    public class WriterMessage : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
