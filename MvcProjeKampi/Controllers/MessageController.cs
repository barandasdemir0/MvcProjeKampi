using BusinessLayer.Concrete;//MessageManager tarafından oluşan kütüphane
using BusinessLayer.ValidationRules;//messagevalidator sonucu oluşan kütüphane
using DataAccsessLayer.EntityFramework;//EfMessageDal sonucu okuşan kütüphane
using EntityLayer.Concrete;
using FluentValidation.Results;//validation sonucu oluşan kütüphane
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
        MessageManager mn = new MessageManager(new EfMessageDal());
        MessageValidator messagevalidator = new MessageValidator();//message validator koşullarına göre nesne üret
        public ActionResult Inbox()
        {
            var messageList = mn.GetListInbox();
            return View(messageList);
        }
        public ActionResult Sendbox()
        {
            var messagelist = mn.GetListSendbox();
            return View(messagelist);
        }

        public ActionResult GetInBoxMessageDetails(int id)
        {
            var values = mn.GetByID(id);
            return View(values);
        }

        public ActionResult GetSendBoxMessageDetails(int id)
        {
            var values = mn.GetByID(id);
            return View(values);
        }

        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            ValidationResult results = messagevalidator.Validate(p);//veriyi üret
            if (results.IsValid)
            {
                p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                mn.MessageAdd(p);//p parametresini ekle
                return RedirectToAction("SendBox");//sayfaya git
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