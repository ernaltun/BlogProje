using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using PagedList;
using PagedList.Mvc;

namespace BlogProje.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        BlogManager bm = new BlogManager();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult BlogList(int page = 1)
        {
            var blogList = bm.GetAll().ToPagedList(page,6);
            //ToPagedList ile db den gelen veriler parçalara ayrılır (başlanacak sayfa,erkanda gösterilmek istenen veri sayısı)
            return PartialView(blogList);
        }
        //Ana sayfa üstteki bloglar
        public PartialViewResult FeaturedPosts()
        {
            // 1.POST
            var posttittle1 = bm.GetAll().OrderByDescending(z=>z.BlogID) //önce hepsini getir sonra terten sırala
                .Where(x => x.CategoryID == 1) //categori id si 1 olanları where ile ayıkla 
                .Select(y => y.BlogTitle).FirstOrDefault(); // first yani ilk ve en büyük değeri bana getir id si en büyük olan sonuncudur

            var postimage1 = bm.GetAll().OrderByDescending(z => z.BlogID) //önce hepsini getir sonra terten sırala
                .Where(x => x.CategoryID == 1) //categori id si 1 olanları where ile ayıkla 
                .Select(y => y.BlogImage).FirstOrDefault(); // first yani ilk ve en büyük değeri bana getir id si en büyük olan sonuncudur

            var blogdate1 = bm.GetAll().OrderByDescending(z => z.BlogID) //önce hepsini getir sonra terten sırala
                .Where(x => x.CategoryID == 1) //categori id si 1 olanları where ile ayıkla 
                .Select(y => y.BlogDate).FirstOrDefault(); // first yani ilk ve en büyük değeri bana getir id si en büyük olan sonuncudur
            ViewBag.posttitle1 = posttittle1;
            ViewBag.postimage1 = postimage1;
            ViewBag.blogdate1 = blogdate1;

            // 2.POST
            var posttittle2 = bm.GetAll().OrderByDescending(z => z.BlogID) //önce hepsini getir sonra terten sırala
                .Where(x => x.CategoryID == 2) //categori id si 1 olanları where ile ayıkla 
                .Select(y => y.BlogTitle).FirstOrDefault(); // first yani ilk ve en büyük değeri bana getir id si en büyük olan sonuncudur

            var postimage2 = bm.GetAll().OrderByDescending(z => z.BlogID) //önce hepsini getir sonra terten sırala
                .Where(x => x.CategoryID == 2) //categori id si 1 olanları where ile ayıkla 
                .Select(y => y.BlogImage).FirstOrDefault(); // first yani ilk ve en büyük değeri bana getir id si en büyük olan sonuncudur

            var blogdate2 = bm.GetAll().OrderByDescending(z => z.BlogID) //önce hepsini getir sonra terten sırala
                .Where(x => x.CategoryID == 2) //categori id si 1 olanları where ile ayıkla 
                .Select(y => y.BlogDate).FirstOrDefault(); // first yani ilk ve en büyük değeri bana getir id si en büyük olan sonuncudur
            ViewBag.posttitle2 = posttittle2;
            ViewBag.postimage2 = postimage2;
            ViewBag.blogdate2 = blogdate2;

            // 3.POST
            var posttittle3 = bm.GetAll().OrderByDescending(z => z.BlogID) //önce hepsini getir sonra terten sırala
                .Where(x => x.CategoryID == 3) //categori id si 1 olanları where ile ayıkla 
                .Select(y => y.BlogTitle).FirstOrDefault(); // first yani ilk ve en büyük değeri bana getir id si en büyük olan sonuncudur

            var postimage3 = bm.GetAll().OrderByDescending(z => z.BlogID) //önce hepsini getir sonra terten sırala
                .Where(x => x.CategoryID == 3) //categori id si 1 olanları where ile ayıkla 
                .Select(y => y.BlogImage).FirstOrDefault(); // first yani ilk ve en büyük değeri bana getir id si en büyük olan sonuncudur

            var blogdate3 = bm.GetAll().OrderByDescending(z => z.BlogID) //önce hepsini getir sonra terten sırala
                .Where(x => x.CategoryID == 3) //categori id si 1 olanları where ile ayıkla 
                .Select(y => y.BlogDate).FirstOrDefault(); // first yani ilk ve en büyük değeri bana getir id si en büyük olan sonuncudur
            ViewBag.posttitle3 = posttittle3;
            ViewBag.postimage3 = postimage3;
            ViewBag.blogdate3 = blogdate3;

            // 4.POST
            var posttittle4 = bm.GetAll().OrderByDescending(z => z.BlogID) //önce hepsini getir sonra terten sırala
                .Where(x => x.CategoryID == 4) //categori id si 1 olanları where ile ayıkla 
                .Select(y => y.BlogTitle).FirstOrDefault(); // first yani ilk ve en büyük değeri bana getir id si en büyük olan sonuncudur

            var postimage4 = bm.GetAll().OrderByDescending(z => z.BlogID) //önce hepsini getir sonra terten sırala
                .Where(x => x.CategoryID == 4) //categori id si 1 olanları where ile ayıkla 
                .Select(y => y.BlogImage).FirstOrDefault(); // first yani ilk ve en büyük değeri bana getir id si en büyük olan sonuncudur

            var blogdate4 = bm.GetAll().OrderByDescending(z => z.BlogID) //önce hepsini getir sonra terten sırala
                .Where(x => x.CategoryID == 4) //categori id si 1 olanları where ile ayıkla 
                .Select(y => y.BlogDate).FirstOrDefault(); // first yani ilk ve en büyük değeri bana getir id si en büyük olan sonuncudur
            ViewBag.posttitle4 = posttittle4;
            ViewBag.postimage4 = postimage4;
            ViewBag.blogdate4 = blogdate4;

            // 5.POST
            var posttittle5 = bm.GetAll().OrderByDescending(z => z.BlogID) //önce hepsini getir sonra terten sırala
                .Where(x => x.CategoryID == 1) //categori id si 1 olanları where ile ayıkla 
                .Select(y => y.BlogTitle).FirstOrDefault(); // first yani ilk ve en büyük değeri bana getir id si en büyük olan sonuncudur

            var postimage5 = bm.GetAll().OrderByDescending(z => z.BlogID) //önce hepsini getir sonra terten sırala
                .Where(x => x.CategoryID == 1) //categori id si 1 olanları where ile ayıkla 
                .Select(y => y.BlogImage).FirstOrDefault(); // first yani ilk ve en büyük değeri bana getir id si en büyük olan sonuncudur

            var blogdate5 = bm.GetAll().OrderByDescending(z => z.BlogID) //önce hepsini getir sonra terten sırala
                .Where(x => x.CategoryID == 1) //categori id si 1 olanları where ile ayıkla 
                .Select(y => y.BlogDate).FirstOrDefault(); // first yani ilk ve en büyük değeri bana getir id si en büyük olan sonuncudur
            ViewBag.posttitle5 = posttittle5;
            ViewBag.postimage5 = postimage5;
            ViewBag.blogdate5 = blogdate5;

            return PartialView();
        }
        public PartialViewResult OtherFeaturedPosts()
        {
            return PartialView();
        }
        public ActionResult BlogDetails()
        {
            return View();
        }
        public PartialViewResult BlogCover(int id)
        {
            var blogDetailsCoverOnly = bm.GetBlogByID(id);
            return PartialView(blogDetailsCoverOnly);
        }
        public PartialViewResult BlogReadAll(int id)
        {
            var blogDetailsList = bm.GetBlogByID(id);
            return PartialView(blogDetailsList);
        }
        public ActionResult BlogByCategory(int id)
        {
            var blogsByCategory = bm.BlogByCategory(id);
            var categoryName = bm.BlogByCategory(id).Select(y=>y.Category.CategoryName).FirstOrDefault();
            ViewBag.categoryName = categoryName;
            var categoryDescription = bm.BlogByCategory(id).Select(z => z.Category.CategoryDescription).FirstOrDefault();
            ViewBag.categoryDescription = categoryDescription;
            return View(blogsByCategory);
        }
        public ActionResult AdminBlogList()
        {
            var blogList = bm.GetAll();
            return View(blogList);
        }
        [HttpGet]
        public ActionResult AddNewBlog()
        {
            #region Kategori/Yazar SelectList
            Context c = new Context(); //contex nesnesi ile tüm sınıflara ulaşıyoruz
            List<SelectListItem>values=(from x in c.Categories.ToList() //selectlistitem sınıf içerisindeki verileri viewbag ile
                select new SelectListItem                               //sayfaya taşımamızı sağlıyor içine sorgu yazılmalı
                { 
                    Text = x.CategoryName, //dropdown da gösterilecek seçeneklerde nasıl seçtirilmeli 
                    Value = x.CategoryID.ToString() //modele gönderilecek veriyi seçiyoruz
                }).ToList(); //listeye atılmalı
            ViewBag.values = values; //selectlist ile çektiğimiz verileri sayfaya çekmek için viewbag içine alıyoruz
            List<SelectListItem>authorValues=(from x in c.Authors.ToList()
                select new SelectListItem
                {
                    Text = x.AuthorName,
                    Value = x.AuthorID.ToString()
                }).ToList();
            ViewBag.authorValues = authorValues;
            #endregion
            return View();
        }
        [HttpPost]
        public ActionResult AddNewBlog(Blog p)
        {
            bm.BlogAddPl(p);
            return RedirectToAction("AdminBlogList");
        }
        public ActionResult DeleteBlog(int id)
        {
            bm.DeleteBlogBL(id);
            return RedirectToAction("AdminBlogList");
        }
        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            Blog blog = bm.FindBlog(id);
                #region Kategori ve Yazar Dropdown
            Context c = new Context(); //contex nesnesi ile tüm sınıflara ulaşıyoruz
            List<SelectListItem> values = (from x in c.Categories.ToList() //selectlistitem sınıf içerisindeki verileri viewbag ile
                                           select new SelectListItem                               //sayfaya taşımamızı sağlıyor içine sorgu yazılmalı
                                           {
                                               Text = x.CategoryName, //dropdown da gösterilecek seçeneklerde nasıl seçtirilmeli 
                                               Value = x.CategoryID.ToString() //modele gönderilecek veriyi seçiyoruz
                                           }).ToList(); //listeye atılmalı
            ViewBag.values = values; //selectlist ile çektiğimiz verileri sayfaya çekmek için viewbag içine alıyoruz
            List<SelectListItem> authorValues = (from x in c.Authors.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.AuthorName,
                                                     Value = x.AuthorID.ToString()
                                                 }).ToList();
            ViewBag.authorValues = authorValues;
            #endregion
            return View(blog);
        }
        [HttpPost]
        public ActionResult UpdateBlog(Blog p)
        {
            bm.UpdateBlog(p);
            return RedirectToAction("AdminBlogList");
        }
        public ActionResult GetCommentById(int id)
        {
            CommentManager commentManager = new CommentManager();
            var commentlist = commentManager.GetCommentByBlog(id);
            var commentdetails = bm.FindBlog(id);
            #region Yorum Detaylarında Blog Bilgisi ViewBagleri
            ViewBag.CommentTitle = commentdetails.BlogTitle;
            ViewBag.CommentId = commentdetails.BlogID;
            ViewBag.BlogImage = commentdetails.BlogImage;
            #endregion
            return View(commentlist);
        }
        public ActionResult GetAuthorAll()
        {
            AuthorManager authorManager = new AuthorManager();
            var authorList = authorManager.GetAll();
            return View(authorList);
        }
    }
}