using BusinessLayer.Concrete;//writer manager sonucu eklenen kütüphane
using DataAccsessLayer.EntityFramework;//efwriter dal sonucu eklenen kütüphane
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
    }
}