using BusinessLayer.Concrete;//heading manager sonrası oluşan kütüphane
using DataAccsessLayer.EntityFramework;//efheadingdal sonucu oluşan kütüphane
using EntityLayer.Concrete;//heading kullanabilmek için
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class HeadingController : Controller
    {
        // GET: Heading
        HeadingManager hm = new HeadingManager(new EfHeadingDal());//headingmanager nesnesinden hm üret bundan sonra hm nesnesini kullancaz
        CategoryManager cm = new CategoryManager(new EfCategoryDal());//CategoryManager nesnesinden cm üret bundan sonra cm nesnesini kullancaz
        public ActionResult Index()
        {
            var headingvalues = hm.GetList();//yani başlık değerleri 
            return View(headingvalues);//headingden gelen değerleri alacan
        }
        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> valuecategory = (from x in cm.GetList()//getlist ile getirme metodunu verdi
                                                  select new SelectListItem//yeni bir liste öğesini seçeceğim
                                                  {
                                                      Text = x.CategoryName,//category ismini göster bana
                                                      Value =x.CategoryID.ToString()//categoryıdsını göster
                                                  }).ToList();//ekleme sayfası yüklendiği zaman bir liste gönderecem listitem ile listeden seçilcek değer bunun ismi valuecategory çünkü categori seçecek LİNQ ile alacak yukarıdaki sorguyu girdik

            //valuemember = benim seçmiş olduğum değerin idsı value = text
            //displaymember =  benim seçmiş olduğumun değerimin görünüm kısmı yani kendisi display = text


            ViewBag.vlc = valuecategory;
            return View();
        }
        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());//bugünün kısa tarihini ekliyor 
            hm.HeadingAdd(p);//parametreden gelen değer
            return RedirectToAction("Index");//indexe git
        }
    }
}