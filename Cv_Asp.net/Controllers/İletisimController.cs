using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cv_Asp.net.Models.Entity;
using Cv_Asp.net.Repositories;

namespace Cv_Asp.net.Controllers
{
    public class İletisimController : Controller
    {
        // GET: İletisim
        GenericRepository<Tbl_İletisim> repo = new GenericRepository<Tbl_İletisim>();
        public ActionResult Index()
        {
            var mesajlar = repo.List();
            return View(mesajlar);
        }
    }
}