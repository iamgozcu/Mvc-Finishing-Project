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
    public class LoginController : Controller
    {
        // GET: admin/Login
        AdministratorRepository administratorRepo = new AdministratorRepository();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(AdminLoginModel a)
        {
            Administrator admin = administratorRepo.AdministratorLogin(a);
            if (admin != null)
            {
                Session["AdminId"] = admin.AdminId;
                return RedirectToAction("Index", "Home");
            }
            return View(admin);
        }

        [ChildActionOnly]
        public ActionResult GetAdminInformation()
        {
            int AdminId = Convert.ToInt32(Session["AdminId"]);
            return View(administratorRepo.SelectById(AdminId));
        }

        [ChildActionOnly]
        [HttpGet]
        public ActionResult ExitAdminSession()
        {
            return View();
        }

        [ChildActionOnly]
        [HttpPost]
        public ActionResult ExitAdminSession(AdminLoginModel a)
        {
            Session.Abandon();
            Response.Redirect("~/Admin/Login/Index");
            return View();
        }
    }
}