using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()//listeleme yapmamıza yarar index
        {
            return View();
        }

        public ActionResult About()//hakkında anlamına gelir about metodu
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()//iletişim metodumuz
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult deneme()//sağ tıklayıp add view yani görünüm ekle diyoruz bunu yazdıktan sonra mvc 5 seçip devam diyoruz ardından
            //use a layout diyoruz 3noktaya basıp view klasörüne gelip shared klasörüne gelip  _layout.cshtml alanına basıp ekliyoruz böylelikle View sayfası ekleniyor
        {
            return View();//geriye bu sayfayı döndüreceksin
        }

        //bunların VİEW tarafında karşılığı vardır
    }
}