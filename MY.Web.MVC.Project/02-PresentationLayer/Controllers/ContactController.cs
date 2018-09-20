using _00_DataAccessLayer.ViewModel;
using _01_BusinesLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_PresentationLayer.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        SettingRepository settingRepo = new SettingRepository();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(SendMailModel s)
        {
            bool sonuc = settingRepo.SendMail(s);
            return View();
        }

        [ChildActionOnly]
        public ActionResult TopAddressPartial()
        {
            return View(settingRepo.GetAll());
        }

        [ChildActionOnly]
        public ActionResult FooterAddressPartial()
        {
            return View(settingRepo.GetAll());
        }

        [ChildActionOnly]
        public ActionResult ContactAddressPartial()
        {
            return View(settingRepo.GetAll());
        }

        [ChildActionOnly]
        public ActionResult ContactMapPartial()
        {
            return View(settingRepo.GetAll());
        }

        [HttpPost]
        public ActionResult SendMailLayout(string EmailAddress)
        {
            bool sonuc = settingRepo.SendMailLayout(EmailAddress);
            if (sonuc == false)
            {
                return Json(new { success = false, responseText = "Mail Gönderilirken Hata Oluştu!" }, JsonRequestBehavior.AllowGet);
            }

            return Json(new { success = true, responseText = "Mail Başarıyla Gönderilmiştir" }, JsonRequestBehavior.AllowGet);

        }

       
    }
}