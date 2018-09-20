using _01_BusinesLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_PresentationLayer.Controllers
{
    public class BrandController : Controller
    {
        // GET: Brand
        BrandRepository brandRepo = new BrandRepository();
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult DefaultBrandPartial()
        {
            return View(brandRepo.GetAll());
        }
    }
}