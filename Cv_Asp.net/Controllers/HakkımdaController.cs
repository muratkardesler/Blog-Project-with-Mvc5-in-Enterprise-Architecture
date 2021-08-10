using Cv_Asp.net.Models.Entity;
using Cv_Asp.net.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cv_Asp.net.Controllers
{
    public class HakkımdaController : Controller
    {
        // GET: Hakkımda
        DbCvEntities db = new DbCvEntities();
        GenericRepository<Tbl_Hakkımda> repo = new GenericRepository<Tbl_Hakkımda>();
        [HttpGet]
        public ActionResult Index()
        {
            var hakkimda = repo.List();

            return View(hakkimda);
        }
        public ActionResult Index(Tbl_Hakkımda p)
        {
            var t = repo.Find(x => x.ID == 1);
            t.Ad = p.Ad;
            t.SoyAd = p.SoyAd;
            t.Adres = p.Adres;
            t.Mail = p.Mail;
            t.Telefon = p.Telefon;
            t.Acıklama = p.Acıklama;
            t.Resim = p.Resim;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}