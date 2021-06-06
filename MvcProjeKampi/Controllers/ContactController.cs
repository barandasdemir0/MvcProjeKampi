using BusinessLayer.Concrete;//contactmanager için
using BusinessLayer.ValidationRules;//contactvalidator sonucu
using DataAccsessLayer.Concrete;
using DataAccsessLayer.EntityFramework;//efcontact için oluşan
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        Context _Context = new Context();
        ContactManager cm = new ContactManager(new EfContactDal());
        ContactValidator cv = new ContactValidator();
        public ActionResult Index()
        {
            var contactvalues = cm.GetList();
            return View(contactvalues);
        }
        public ActionResult GetContactDetails(int id)
        {
            var contactvalues = cm.GetByID(id);
            return View(contactvalues);
        }
        public PartialViewResult contactpartial()
        {
            //burası iletişim gelen mesajlar ve gönderilen mesajlar için
            var receiverMail = _Context.Messages.Count(x => x.ReceiverMail == "07baran06@gmail.com").ToString();
            ViewBag.receiverMail = receiverMail;

            var senderMail = _Context.Messages.Count(x => x.SenderMail == "07baran06@gmail.com").ToString();
            ViewBag.senderMail = senderMail;

            var contact = _Context.Contacts.Count().ToString();
            ViewBag.contact = contact;
            return PartialView();
        }
    }
}