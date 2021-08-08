using Cv_Asp.net.Models.Entity;
using Cv_Asp.net.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace Cv_Asp.net.Controllers
{
    public class DeneyimController : Controller
    {
        // GET: Deneyim
        DeneyimRepository repo = new DeneyimRepository();
        public ActionResult Index()
        {
            var degerler = repo.List();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult DeneyimEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeneyimEkle(Tbl_Deneyimler p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
       public ActionResult DeneyimSil(int id)
        {
            Tbl_Deneyimler t = repo.Find(x => x.ID == id);
            repo.Tdelete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeneyimGetir(int id)
        {
            Tbl_Deneyimler t = repo.Find(x => x.ID == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult DeneyimGetir(Tbl_Deneyimler p)
        {
            Tbl_Deneyimler t = repo.Find(x => x.ID ==p.ID);
            t.Baslık = p.Baslık;
            t.AltBaslık = p.AltBaslık;
            t.Tarih = p.Tarih;
            repo.TUpdate(t);
            return RedirectToAction("Index");
            
        }
    }
}