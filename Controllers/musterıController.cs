using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSTOK2.Models.Entity;

namespace MVCSTOK2.Controllers
{
    public class musterıController : Controller
    {
        // GET: musterı
        MVCSTOKEntities1 db = new MVCSTOKEntities1();
        public ActionResult Index()
        {
            var degerler = db.TBLMUSTERILER.ToList();
            return View(degerler);
        }

    }
}