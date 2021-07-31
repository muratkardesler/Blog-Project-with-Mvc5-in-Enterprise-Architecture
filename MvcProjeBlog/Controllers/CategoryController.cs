using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeBlog.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager();
        public ActionResult Index()
        {
            var categoryvalues = cm.GetAll();
            return View(categoryvalues);
        }
        public PartialViewResult BlogDetailCategoryList()
        {
            var categoryvalues = cm.GetAll();
            return PartialView(categoryvalues);
        }
    }
}