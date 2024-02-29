using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;

namespace BlogProje.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager();
        public ActionResult Index()
        {
            var categoryValues = cm.GetAll();
            return View(categoryValues);
        }
        public PartialViewResult BlogDetailsCategoryList()
        {
            var categoryValues = cm.GetAll();
            return PartialView(categoryValues);
        }
        public ActionResult AdminCategoryList()
        {
            var categories = cm.GetAll();
            return View(categories);
        } 
    }
} 