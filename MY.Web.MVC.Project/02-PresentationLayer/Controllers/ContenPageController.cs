using _01_BusinesLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_PresentationLayer.Controllers
{
    public class ContenPageController : Controller
    {
        // GET: ContenPage
        ContentPageRepository contentPageRepo = new ContentPageRepository();
        public ActionResult Index(int id)
        {
            return View(contentPageRepo.SelectById(id));
        }

        [ChildActionOnly]
        public ActionResult FooterContentPagePartial()
        {
            return View(contentPageRepo.GetAll());
        }
    }
}