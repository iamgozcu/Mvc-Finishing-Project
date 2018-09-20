using _00_DataAccessLayer.ViewModel;
using _01_BusinesLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_PresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        ShowcaseProductRepository showcaseProductRepo = new ShowcaseProductRepository();
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult ShowcaseProductListPartial()
        {
            return View(showcaseProductRepo.ShowcaseProductListModel());
        }

    }
}