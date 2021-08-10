using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cv_Asp.net.Models.Entity;
using Cv_Asp.net.Repositories;

namespace Cv_Asp.net.Controllers
{
    public class HobiController : Controller
    {
        // GET: Hobi
        GenericRepository<Tbl_Hobiler> repo = new GenericRepository<Tbl_Hobiler>();
        [HttpGet]
        public ActionResult Index()
        {
            
            var hobiler = repo.List();
            return View(hobiler);
        }
        //güncelleme işlemi için
        [HttpPost]
        public ActionResult Index(Tbl_Hobiler p)
        {
            var t = repo.Find(x => x.ID == 1);
            t.Acıklama1 = p.Acıklama1;
            t.Acıklama2 = p.Acıklama2;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}