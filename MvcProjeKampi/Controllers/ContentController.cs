using BusinessLayer.Concrete;//content manager sonucu eklenen kütüphane
using DataAccsessLayer.EntityFramework;//efcontentdal sonucu eklenen kütüphane
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        ContentManager cm = new ContentManager(new EfContentDal());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ContentByHeading(int id)//içerikleri getir neye göre başlığa göre
        {
            var contentvalues = cm.GetListByHeadingID(id);
            return View(contentvalues);
            //sen bana contentvaluesten gelen değerleri liste formatında döndüreceksin
        }
    }
}