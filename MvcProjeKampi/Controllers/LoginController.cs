using DataAccsessLayer.Concrete;//context sonucu oluşan kütüphane
using EntityLayer.Concrete;//admin tablosu
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

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
            if (adminuserinfo != null)//değilse
            { 
                FormsAuthentication.SetAuthCookie(adminuserinfo.AdminUserName,false);//formauthentiacation yukarıdaki security kütüphanesini ekledi setauthcookie çerezi hallediyor paranez ile form yetkisi kimde olacak sisteme giriş yapan kullanıcıda adminuserinfodan gelen adminusername false ise kalıcı cookie oluşturulsun mu diyor
                Session["AdminUserName"] = adminuserinfo.AdminUserName;//sisteme otantike olan kullanıcının bilgisi böylece gelecek
                return RedirectToAction("Index","AdminCategory");
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }
    }
}