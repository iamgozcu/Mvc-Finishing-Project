using _00_DataAccessLayer.Entity;
using _00_DataAccessLayer.ViewModel;
using _01_BusinesLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_PresentationLayer.Areas.admin.Controllers
{
    public class SettingController : Controller
    {
        // GET: admin/Setting
        SettingRepository settingRepo = new SettingRepository();

        [HttpGet]
        public ActionResult Index()
        {
            Setting setting = settingRepo.SelectById1();
            SettingModel settingmodel = new SettingModel()
            {
                SettingId = setting.SettingId,
                BasketLimitKeeps = setting.BasketLimitKeeps,
                OrderEmailAddress = setting.OrderEmailAddress,
                ContactMailAddress = setting.ContactMailAddress,
                Address = setting.Address,
                PostCode = setting.PostCode,
                CompanyName = setting.CompanyName,
                GSM = setting.GSM,
                Phone = setting.Phone,
                Phone2 = setting.Phone2,
                Fax = setting.Fax,
                Map = setting.Map,
                CompanyNumber = setting.CompanyNumber,
                Slogan = setting.Slogan,
                Facebook = setting.Facebook,
                Twitter = setting.Twitter,
                Instagram = setting.Instagram,
                Linkedin = setting.Linkedin,
                Google = setting.Google
            };

            return View(settingmodel);
        }

        [HttpPost]
        public ActionResult Index(SettingModel settingmodel)
        {

            Setting setting = new Setting()
            {
                SettingId = settingmodel.SettingId,
                OrderEmailAddress = settingmodel.OrderEmailAddress,
                ContactMailAddress = settingmodel.ContactMailAddress,
                Address = settingmodel.Address,
                PostCode = settingmodel.PostCode,
                CompanyName = settingmodel.CompanyName,
                GSM = settingmodel.GSM,
                Phone = settingmodel.Phone,
                Phone2 = settingmodel.Phone2,
                Fax = settingmodel.Fax,
                Map = settingmodel.Map,
                CompanyNumber = settingmodel.CompanyNumber,
                Slogan = settingmodel.Slogan,
                Facebook = settingmodel.Facebook,
                Twitter = settingmodel.Twitter,
                Instagram = settingmodel.Instagram,
                Linkedin = settingmodel.Linkedin,
                Google = settingmodel.Google
            };

            settingRepo.Update(setting);
            return RedirectToAction("Index");
        }
    }
}