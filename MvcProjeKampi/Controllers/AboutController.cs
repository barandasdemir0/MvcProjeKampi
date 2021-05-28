using BusinessLayer.Concrete;//aboutmanager sonucu oluşan kütüphane
using DataAccsessLayer.EntityFramework;//efabaoutdal sonucu eklenen kütüphane
using EntityLayer.Concrete;//aboutta oluşan hata
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AboutController : Controller
    {
        AboutManager abm = new AboutManager(new EfAboutDal());
        // GET: About
        public ActionResult Index()
        {
            var aboutvalues = abm.GetList();//var türünde aboutvalues değeri oluşturduk abm yolu ile getlisti çağırdık get list ne idi listeleme metodu idi
            return View(aboutvalues);//wiev ile değeri döndürdük
        }
        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAbout(About p)
        {
            abm.AboutAdd(p);//abmaboutadd ekle p parametresinden gelen değeri
            return RedirectToAction("Index");//işlem olunca indexe geri dön
        }
        public PartialViewResult AboutPartial()
        {
            return PartialView();
        }
    }
}