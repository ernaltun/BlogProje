using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;

namespace BlogProje.Controllers
{
    public class AuthorController : Controller
    {
        BlogManager blogManager = new BlogManager();
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
        
    }
}