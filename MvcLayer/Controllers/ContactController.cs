using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace MvcLayer.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EFContactRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact p)
        {
            p.ContactDate = DateTime.Now;
            p.ContactStatus = true;
            cm.AddContact(p);
            return RedirectToAction("Index","Blog");
        }
    }
}
