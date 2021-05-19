using BusinessLayer.Concrete;//writer manager sonucu eklenen kütüphane
using BusinessLayer.ValidationRules;//writervalidator sonucu gelen kütüphane
using DataAccsessLayer.EntityFramework;//efwriter dal sonucu eklenen kütüphane
using EntityLayer.Concrete;//writer sonucu eklenen kütüphane
using FluentValidation.Results;//validation results sonucu eklenen kütüphane
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class WriterController : Controller
    {
        //business sınıfını çağırıyoruz bunun entityframeworkunu aldık ardından
        WriterManager wm = new WriterManager(new EfWriterDal());
        WriterValidator writervalidator = new WriterValidator();//writer validator koşullarına göre nesne üret
        // GET: Writer
        public ActionResult Index()
        {
            var WriterValues = wm.GetList();//listeleme yapmasını istedik
            return View(WriterValues);//bize writer valuesini yani listelemesini istedik
        }
        [HttpGet]
        public ActionResult AddWriter()//yazar eklemek için
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddWriter(Writer p)//yazar eklemek için
        {
            ValidationResult results = writervalidator.Validate(p);//veriyi üret
            if (results.IsValid)
            {
                wm.WriterAdd(p);//p parametresini ekle
                return RedirectToAction("Index");//sayfaya git
            }
            else
            {
                foreach (var item in results.Errors)//aksi takdirde hata verirse
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);//hata ver
                }
            }
            return View();
        }
        [HttpGet]//sen get etiketiyle çalış
        public ActionResult EditWriter(int id)
        {
            var writervalue = wm.GetByID(id);//yazar değeri = idye göre getir
            return View(writervalue);//bana view döndür buda writervalue olsun

        }
        [HttpPost]//sen get etiketiyle çalış
        public ActionResult EditWriter(Writer p)//writer sınıfındna p aldın
        {
            ValidationResult results = writervalidator.Validate(p);//veriyi üret
            if (results.IsValid)
            {
                wm.WriterUpdate(p);//parametreden gelen değere göre güncelle//p parametresini ekle
                return RedirectToAction("Index");//sayfaya git
            }
            else
            {
                foreach (var item in results.Errors)//aksi takdirde hata verirse
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);//hata ver
                }
            }
            return View();
        }
    }
}