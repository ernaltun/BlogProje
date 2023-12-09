using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;

namespace BlogProje.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager();
        public PartialViewResult CommentList(int id)
        { //LİSTEYİ İÇİNE ATTIĞIN DEĞİŞKİNİ DÖNDÜRMEYİ UNUTMA
            var commentList = commentManager.GetCommentByBlog(id);
            return PartialView(commentList); //
        }
        [HttpGet]
        public PartialViewResult LeaveComment(int id)
        {
            ViewBag.id = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult LeaveComment(Comment c)
        {
            commentManager.CommentAdd(c);
            return PartialView();
        }

    }
}