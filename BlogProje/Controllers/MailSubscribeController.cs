using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;

namespace BlogProje.Controllers
{
    public class MailSubscribeController : Controller
    {
        [HttpGet]
        public PartialViewResult AddMail()
        {
            return PartialView();
        }
        [HttpPost] //aynı isimde 2 tane method var ise birisinde parametre vermelisin
        public PartialViewResult AddMail(SubscribeMail p)
        {
            SubscribeMailManager sm = new SubscribeMailManager();
            sm.BLAdd(p);
            return PartialView();
        }
    }
}