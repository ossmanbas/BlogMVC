﻿using BusinessLayer.Concreate;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcLayer.Controllers
{
    public class BlogController : Controller
    {
        CategoryManager cm = new CategoryManager(new EFCategoryRepository());
        BlogManager bm = new BlogManager(new EFBlogRepository());

       
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }
        public IActionResult BlogDetails(int id)
        {
            ViewBag.i = id;
            var blog = bm.GetBlogById(id);
            return View(blog);
        }

        public IActionResult BlogListByWriter()
        {
            var values = bm.GetListWithCategoryByWriterBm(1);
            return View(values);
        }

        public IActionResult DeleteBlog(int id)
        {
            var blogvalue = bm.TGetById(id);
            bm.TRemove(blogvalue);
            return RedirectToAction("BlogListByWriter");

        }

      



        [HttpGet]
        public IActionResult BlogAdd()
        {
           
            List<SelectListItem> Kategoriler = (from x in cm.GetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.CategoryName,
                                                    Value = x.CategoryID.ToString()
                                                }).ToList();
            ViewBag.kategori = Kategoriler;

            return View();
        }

        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {

            BlogValidator bv = new BlogValidator();     // Validatorde yazdığımız koşulların kontrolü için
            ValidationResult result = bv.Validate(p);   // Validatorde yazdığımız koşulların kontrolü için
            if (result.IsValid)                         // Validatorde yazdığımız koşulların kontrolü için
            {
                List<SelectListItem> Kategoriler = (from x in cm.GetList()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.CategoryName,
                                                        Value = x.CategoryID.ToString()
                                                    }).ToList();

                p.BlogStatus = true;
                p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterID = 2;
                p.BlogID = 19;
                bm.TAdd(p);
                return RedirectToAction("BlogListByWriter", "Blog");
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

        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            var blogvalue = bm.TGetById(id);
            List<SelectListItem> Kategoriler = (from x in cm.GetList()
                                                select new SelectListItem
                                                {
                                                    Text = x.CategoryName,
                                                    Value = x.CategoryID.ToString()
                                                }).ToList();
            ViewBag.kategori = Kategoriler;
            return View(blogvalue);

        }
        
        [HttpPost]
        public IActionResult EditBlog(Blog b)
        {
            var blogValue = bm.TGetById(b.BlogID);
            b.BlogCreateDate  = DateTime.Parse(blogValue.BlogCreateDate.ToShortDateString());
            b.WriterID = 1;
            b.BlogStatus = true;
            bm.TUpdate(b);
            return RedirectToAction("BlogListByWriter");
        }
    }
}
