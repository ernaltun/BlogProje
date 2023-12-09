using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;

namespace BlogProje.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager();
        // GET: About
        public ActionResult Index()
        {
            var aboutContent = aboutManager.GetAll();
            return View(aboutContent);
        }
        public PartialViewResult Footer()
        {
            var aboutContentList = aboutManager.GetAll();
            //ViewBag.Hakkımızda = aboutManager.GetAll().Where(p=>p.AboutID==1).Select(p=>p.AboutContent1);
            return PartialView(aboutContentList);
        }
        public PartialViewResult MeetTheTeam()
        {
            AuthorManager authorManager = new AuthorManager();
            var teamMembers = authorManager.GetAll();
            return PartialView(teamMembers);
        }
    }
}