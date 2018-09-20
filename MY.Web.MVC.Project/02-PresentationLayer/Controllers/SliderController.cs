using _01_BusinesLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_PresentationLayer.Controllers
{
    public class SliderController : Controller
    {
        // GET: Slider
        SliderRepository sliderRepo = new SliderRepository();
        public ActionResult Index()
        {
            return View();
        }


        [ChildActionOnly]
        public ActionResult DefaultSliderPartial()
        {
            return View(sliderRepo.GetAll());
        }
    }
}