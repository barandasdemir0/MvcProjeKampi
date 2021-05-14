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
            WriterValidator writervalidator = new WriterValidator();
            ValidationResult results = writervalidator.Validate(p);
            if (results.IsValid)
            {
                wm.WriterAdd(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}