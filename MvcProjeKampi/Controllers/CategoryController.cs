using BusinessLayer.Concrete;//bu eklenince hata kalktı ve business layerdaki category manager eklendi
using BusinessLayer.ValidationRules;//validatior hatasına basınca bu kütüphane ekleniyor ve hata kalkıyor
using DataAccsessLayer.EntityFramework;//new efcategory hata düzeltme sonucu eklendi
using EntityLayer.Concrete;//bu eklenince hata kalktı ve entitiylayerdaki category eklendi
using FluentValidation.Results;//1.cisi değil 2.ciyi seçtik validation resultsdaki bunu gönderdi 1.değil 2.geldi
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager(new EfCategoryDal());//businesslayerdaki categorymanagerı çağırdık
        //ama new efcategorydal diyerek parametremizi aldık nerden gelen category managerdeaki  
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCatgoryList()
        {
             var categoryvalues = cm.GetList();//category values tanımladık sonra categorymanageri cm olarak tanımlamıştık ya ve category managerde getallvardı onu çapırdık
            return View(categoryvalues);//sonra değeri döndürdük neyle categoryvalues ile yani viewe aktardık verileri ---> categoryvalues kaldırdık --> geri ekledik
        }
        [HttpGet]//yani sen sayfam yüklenirken  zaman çalışacaksın 
        public ActionResult AddCategory()
        {
            return View();//senden tek istediğim sayfayı tekrardan döndür
        }
        [HttpPost]//yani sen sayfamda butona tıkladığımda zaman çalışacaksın yani sayfada post yapıldığında

        //Aşağıdaki yanlış kullandımdır yeni kategori butonu çıkacak ve basınca boş veri ekleyecek sebebi sen sayfayı yükler yüklemez komutlar devreye giriyor
        public ActionResult AddCategory(Category p)//category sınıfından p parametresi ürerttim
        {
            CategoryValidator categoryValidator = new CategoryValidator();//categoryvalidatorden categoryvalidator adında nesne türettik ve categoryvalidatoru çağırdık
            ValidationResult results = categoryValidator.Validate(p);
            //results isminde değişken oluşutrduk results category validaterden gelen değerlere göre validasyon yap yani kontrol yap buda neyere göre parametrenin p si
            if (results.IsValid)//sonuc results doğruysa
            {
                cm.CategoryAdd(p);//cm neydi categorymanagerden category dala göre türettüğümüz nesnemizdi
                return RedirectToAction("GetCatgoryList");//beni aksiyona yönlendir hangi aksiyon redirect action list
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);//modelin durumuna hataları ekle bu hatalar neler olacak dizinin öpesi item yani prpert ismi ve mesaj
                }
            }

            // cm.CategoryAddBL(p);//ekleme işlemini yap
            //ekleme işlemini gerçekleştirdikten sonra
            return View();// RedirectToAction("GetCatgoryList");--> hata çıkarmayınca//beni tanımlamış olduğum metoda yönlendir onu da yukarı da tanımladık yukarı bak
        }
    }
}