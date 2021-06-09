using DataAccsessLayer.Concrete;//context sonucu oluşan kütüphane
using EntityLayer.Concrete;//admin tablosu
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin p)
        {
            Context c = new Context();
            var adminuserinfo = c.Admins.FirstOrDefault(x => x.AdminUserName == p.AdminUserName && x.AdminPassword == p.AdminPassword); // eğer ki veritabanındaki(x yani) kullanıcı parametreden(p yani) gelen kullanıcı adına eşit ise ve veritabanındaki(x yani) şifre parametreden(p yani) gelen şifre adına eşit ise
            if (adminuserinfo!=null)//değilse
            {
                return RedirectToAction("Index","AdminCategory");
            }
            else
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}