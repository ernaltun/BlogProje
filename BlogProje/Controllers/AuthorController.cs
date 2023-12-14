using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Design;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;

namespace BlogProje.Controllers
{
    public class AuthorController : Controller
    {
        BlogManager blogManager = new BlogManager();
        AuthorManager authorManager = new AuthorManager();
        public PartialViewResult AuthorAbout(int id)
        {
            var authorDetail = blogManager.GetBlogByID(id);
            return PartialView(authorDetail);
        }
        public PartialViewResult AuthorPopularPost(int id)
        {
            var blogAuthorid = blogManager.GetAll().Where(x => x.BlogID == id).Select(y => y.AuthorID).FirstOrDefault();
            
            var authorblogs = blogManager.GetBlogByAuthor(blogAuthorid);
            return PartialView(authorblogs);
        }
        [HttpGet]
        public ActionResult AddAuthor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAuthor(Author p)
        {
            authorManager.AddAuthorBL(p);
            return RedirectToAction("GetAuthorAll", "Blog", new { area = "" });
        }
        [HttpGet]
        public ActionResult UpdateAuthor(int id)
        {
            Author author = authorManager.FindAuthor(id);
            return View(author);
        }
        [HttpPost]
        public ActionResult UpdateAuthor(Author p)
        {
            authorManager.UpdateAuthorBL(p);
            return RedirectToAction("GetAuthorAll", "Blog", new { area = "" });
        }
        
    }
}