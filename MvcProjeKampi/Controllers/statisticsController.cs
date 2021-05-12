using DataAccsessLayer.Concrete;//dataaccessten concrete eklendi neden context oradaydı
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class statisticsController : Controller
    {
        // GET: statistics
        Context context = new Context();//contexti çağırdık içinde verilerimiz vardı başlık yazar gibi şeyler
        public ActionResult Index()
        {

            var kategorigetir = context.Categories.Count().ToString();
            ViewBag.kategorigetir = kategorigetir;

            var yazilim = context.Headings.Count(x => x.Category.CategoryID == 8);
            ViewBag.yazilim = yazilim;

            var yazar = context.Writers.Count(x => x.WriterName.Contains("a"));
            ViewBag.yazar = yazar;

            var baslik = context.Headings.Max(x => x.Category.CategoryName);
            ViewBag.baslik = baslik;

            var trueolanlar = context.Categories.Count(x => x.CategoryStatus == true);
            var falseolanlar = context.Categories.Count(x => x.CategoryStatus == false);
            ViewBag.status = (trueolanlar - falseolanlar);

            return View();
        }
    }
}