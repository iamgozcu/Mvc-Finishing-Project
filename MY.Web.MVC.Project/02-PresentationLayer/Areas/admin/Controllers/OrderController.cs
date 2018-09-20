using _01_BusinesLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_PresentationLayer.Areas.admin.Controllers
{
    public class OrderController : Controller
    {
        // GET: admin/Order
        OrderRepository orderRepo = new OrderRepository();
        public ActionResult Index()
        {
            return View(orderRepo.OrderListModel());
        }
    }
}