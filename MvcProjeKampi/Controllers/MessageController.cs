using BusinessLayer.Concrete;//MessageManager tarafından oluşan kütüphane
using DataAccsessLayer.EntityFramework;//EfMessageDal sonucu okuşan kütüphane
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        MessageManager cm = new MessageManager(new EfMessageDal());
        public ActionResult Inbox()
        {
            var messageList = cm.GetList();
            return View(messageList);
        }
    }
}