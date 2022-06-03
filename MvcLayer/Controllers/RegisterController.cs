using BusinessLayer.Concreate;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using FluentValidation.Results;
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
            WriterValidator wv = new WriterValidator(); // Validatorde yazdığımız koşulların kontrolü için
            ValidationResult result = wv.Validate(p);   // Validatorde yazdığımız koşulların kontrolü için
            if (result.IsValid)                         // Validatorde yazdığımız koşulların kontrolü için
            {
                p.WriterStatus = true;
                p.WriterAbaout = "hebele hübele";
                wm.AddWriter(p);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
            
        }
    }
}
