using BusinessLayer.Concrete;
using PagedList;
using PagedList.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcProjeBlog.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        BlogManager bm = new BlogManager();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult BlogList(int page=1)
        {
            var bloglist = bm.GetAll().ToPagedList(page,6);//bütün değerleri bana getir
            return PartialView(bloglist); //geriye bloglist döndür
        }
        public PartialViewResult FeaturedPosts()
        {
            //1.post
            var posttitle1 = bm.GetAll().OrderByDescending(z=>z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage1= bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate1= bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogDate).FirstOrDefault();

            ViewBag.posttitle1 = posttitle1;
            ViewBag.postimage1 = postimage1;
            ViewBag.blogdate1 = blogdate1;

            //2.post
            var posttitle2 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage2 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate2 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogDate).FirstOrDefault();

            ViewBag.posttitle2 = posttitle2;
            ViewBag.postimage2 = postimage2;
            ViewBag.blogdate2 = blogdate2;

            //3.post
            var posttitle3 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage3 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate3 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogDate).FirstOrDefault();

            ViewBag.posttitle3 = posttitle3;
            ViewBag.postimage3 = postimage3;
            ViewBag.blogdate3 = blogdate3;

            //4.post
            var posttitle4 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage4 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate4 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogDate).FirstOrDefault();

            ViewBag.posttitle4 = posttitle4;
            ViewBag.postimage4 = postimage4;
            ViewBag.blogdate4 = blogdate4;

            //4.post
            var posttitle5 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 5).Select(y => y.BlogTitle).FirstOrDefault();
            var postimage5 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 5).Select(y => y.BlogImage).FirstOrDefault();
            var blogdate5 = bm.GetAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 5).Select(y => y.BlogDate).FirstOrDefault();

            ViewBag.posttitle5 = posttitle5;
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
            // bloğa ait verilerin gelmesi
            return View();
        }
        public PartialViewResult BlogCover(int id)
        {
            var BlogDetailsList = bm.GetBlogByID(id);
            return PartialView(BlogDetailsList);
        }
        public PartialViewResult BlogReadAll(int id)
        {
            var BlogDetailsList = bm.GetBlogByID(id);
            

            return PartialView(BlogDetailsList); 
            
        }
        public ActionResult BlogByCategory()
        {
            return View();
        }

    }
}