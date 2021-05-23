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
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ContentByHeading()//içerikleri getir neye göre başlığa göre
        {
            return View();
        }
    }
}