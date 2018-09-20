using _00_DataAccessLayer.Entity;
using _00_DataAccessLayer.ViewModel;
using _01_BusinesLayer.Repositories;
using System;
using System.Web.Mvc;

namespace _02_PresentationLayer.Areas.admin.Controllers
{
    public class CustomerController : Controller
    {
        // GET: admin/Customer
        CustomerRepository customerRepo = new CustomerRepository();
        public ActionResult Index()
        {
            return View(customerRepo.GetAll());
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
            return RedirectToAction("Index");
        }

        public ActionResult Detail()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult CustomerDetailEditPartial(int id)
        {
            Customer customer = customerRepo.SelectById(id);
            return View(customer);
        }

    }
}