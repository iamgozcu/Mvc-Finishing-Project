using _00_DataAccessLayer.Entity;
using _00_DataAccessLayer.ViewModel;
using _01_BusinesLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_PresentationLayer.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        CustomerRepository customerRepo = new CustomerRepository();
        SettingRepository settingRepo = new SettingRepository();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CustomerModel c)
        {
            Customer customer = new Customer()
            {
                CustomerName = c.CustomerName,
                CustomerSurname = c.CustomerSurname,
                EmailAddress = c.EmailAddress,
                Password = c.Password,
                MembershipDate = DateTime.Now,
                ActivePassive = true
            };
            customerRepo.Insert(customer);
            Session["CustomerId"] = customer.CustomerId;
            return View();
        }

        [ChildActionOnly]
        public ActionResult TopCustomerSession(int customerId)
        {
            return View(customerRepo.SelectById(customerId));
        }

        [HttpGet]
        public ActionResult Login()
        {
            int sessionSorgula = Convert.ToInt32(Session["CustomerId"]);
            if (sessionSorgula != 0)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserLoginModel c)
        {
            Customer customer = customerRepo.CustomerLogin(c);
            if (customer!=null)
            {
                Session["CustomerId"] = customer.CustomerId;
                return RedirectToAction("Index", "Home");
            }
            return View(customer);
        }

        public ActionResult Logout()
        {
            Session["CustomerId"] = 0;
            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public ActionResult GetPassword()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetPasswordMail(string EmailAddress)
        {
           Customer customer= customerRepo.SelectByEmail(EmailAddress);
            if (customer==null)
            {
                return Json(new { success = false, responseText = "Mail Adresi Sistemde Kayıtlı Değil!" }, JsonRequestBehavior.AllowGet);
            }

            settingRepo.SendMailPasword(customer);
            return Json(new { success = true, responseText = "Şifreniz Mail Adresinize Gönderilmiştir." }, JsonRequestBehavior.AllowGet);
        }

    }
}