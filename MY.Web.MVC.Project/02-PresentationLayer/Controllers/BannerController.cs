using _00_DataAccessLayer.Entity;
using _01_BusinesLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_PresentationLayer.Controllers
{
    public class BannerController : Controller
    {
        // GET: Banner
        BannerRepository bannerRepo = new BannerRepository();
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult DefaultBannerPartial()
        {
            return View();
        }
    }
}