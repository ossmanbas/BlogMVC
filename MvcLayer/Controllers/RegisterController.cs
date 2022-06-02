using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace MvcLayer.Controllers
{
    public class RegisterController : Controller
    {
        //Ekleme işlemi yapılırken httpget ve httppost Attrubutelerinin ismi aynı olmak ZORUNDADIR.
        //httpget --> Sayfa Yüklenince çalışacak.
        //httppost --> Sayfada Buton Tetiklenince çalışacak.

        WriterManager wm = new WriterManager(new EFWriterRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer p)
        {
            p.WriterStatus = true;
            p.WriterAbaout = "hebele hübele";
            wm.AddWriter(p);
            return RedirectToAction("Index","Blog");
        }
    }
}
