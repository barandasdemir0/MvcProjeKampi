using BusinessLayer.Concrete;//categorymanager sonucu eklenen kütüphane
using BusinessLayer.ValidationRules;//categoryvalidator sonunda eklenen kütüphane
using DataAccsessLayer.EntityFramework;//efcategorydal sonucu eklenen kütüphane
using EntityLayer.Concrete;//category dediğimiz zaman eklenen kütüphane
using FluentValidation.Results;//validation result sonucu eklenen kütüphane
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AdminCategoryController : Controller
    {
        // GET: AdminCategory
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            var categoryvalues = cm.GetList();
            return View(categoryvalues);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(p);
            if (results.IsValid)
            {
                cm.CategoryAdd(p);
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
        public ActionResult DeleteCategory(int id)
        {
            var categoryvalue = cm.GetByID(id);//var türünde değişken oluşturduk ardından vategoryvalue dedik ve cm dedik cm categorymanagerden getbyıdyi getir neye göre getir yukarıda tanımladığımız id ye göre getir
            cm.CategoryDelete(categoryvalue);//categorydelete neyi silecez category value adlı değikenden gelen veriyi silecek
            return RedirectToAction("Index");//beni tekrardan yönlendir nereye indexe
        }
        [HttpGet]//sayfam yüklendiğinde senin çalışmanı istiyorum
        public ActionResult EditCategory(int id)
        {
            var categoryvalue = cm.GetByID(id);//var türünde değişken oluşturduk ardından vategoryvalue dedik ve cm dedik cm categorymanagerden getbyıdyi getir neye göre getir yukarıda tanımladığımız id ye göre getir
            return View(categoryvalue);//değikenle beraber döndür
        }
        [HttpPost]//sayfam yüklendiğinde senin çalışmanı istiyorum
        public ActionResult EditCategory(Category p)
        {
            cm.CategoryUpdate(p);//update et neyden gelen değeri p den gelen değeri
            return RedirectToAction("Index");
        }
    }
}