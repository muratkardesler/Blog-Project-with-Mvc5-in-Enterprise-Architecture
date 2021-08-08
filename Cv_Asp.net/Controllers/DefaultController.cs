using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cv_Asp.net.Models.Entity; // kütüphaneyi ekledik

namespace Cv_Asp.net.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {
            var degerler = db.Tbl_Hakkımda.ToList();
            return View(degerler);
        }
        public PartialViewResult Deneyim()
        {
            var deneyimler = db.Tbl_Deneyimler.ToList();
            return PartialView(deneyimler);
        }
        public PartialViewResult Egitimlerim()
        {
            var egitimler = db.Tbl_Egitim.ToList();
            return PartialView(egitimler);
        }
        public PartialViewResult yeteneklerim()
        {
            var yetenekler = db.Tbl_Yetenek.ToList();
            return PartialView(yetenekler);
        }
        public PartialViewResult Hobilerim()
        {
            var Hobiler = db.Tbl_Hobiler.ToList();
            return PartialView(Hobiler);
        }
        public PartialViewResult Sertifikalarım()
        {
            var Sertifikalar = db.Tbl_Sertifikalar.ToList();
            return PartialView( Sertifikalar);
        }
        [HttpGet]
        public PartialViewResult İletisim()
        {
            
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult İletisim(Tbl_İletisim t)
        {
            t.Tarih = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.Tbl_İletisim.Add(t);
            db.SaveChanges();
            return PartialView();
        }

    }
       
}