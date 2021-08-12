using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cv_Asp.net.Models.Entity;
using Cv_Asp.net.Repositories;

namespace Cv_Asp.net.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        GenericRepository<Tbl_Admin> repo = new GenericRepository<Tbl_Admin>();
        public ActionResult Index()
        {
            var liste = repo.List();
            return View(liste);
        }       
        [HttpGet]
        public ActionResult AdminEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminEkle(Tbl_Admin p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult AdminSil(int id)
        {
            Tbl_Admin t = repo.Find(x => x.ID == id);
            repo.Tdelete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AdminDuzenle(int id)
        {
            Tbl_Admin t = repo.Find(x => x.ID == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult AdminDuzenle(Tbl_Admin p)
        {
            Tbl_Admin t = repo.Find(x => x.ID == p.ID);
            t.KullaniciAdi = p.KullaniciAdi;
            t.Sifre = p.Sifre;          
            repo.TUpdate(t);
            return RedirectToAction("Index");

        }
    }
}