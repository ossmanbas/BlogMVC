using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MvcLayer.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            CategoryManager cm = new CategoryManager(new EFCategoryRepository());
            var values = cm.GetList();
            return View(values);
        }
    }
}
