using _00_DataAccessLayer.Entity;
using _00_DataAccessLayer.ViewModel;
using _01_BusinesLayer.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_PresentationLayer.Areas.admin.Controllers
{
    public class SliderController : Controller
    {
        // GET: admin/Slider
        SliderRepository sliderRepo = new SliderRepository();
        public ActionResult Index()
        {
            return View(sliderRepo.GetAll());
        }

        [HttpPost]
        public JsonResult DeleteSlider(int id)
        {
            Slider firstslider = sliderRepo.SelectById(id);
            if (firstslider == null)
            {
                return Json(new { success = false, responseText = "Slider silinemedi!" }, JsonRequestBehavior.AllowGet);
            }
            sliderRepo.Delete(firstslider);
            return Json(new { success = true, responseText = "Slider Silme işlemi gerçekleşmiştir." }, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(SliderModel slidermodel, HttpPostedFileBase image)
        {
            if (image != null && image.ContentLength > 0)
            {
                var fileName = Path.GetFileName(image.FileName);
                slidermodel.SliderImage = fileName;
                var path = Path.Combine(Server.MapPath("~/Content/images/slider"), fileName);
                image.SaveAs(path);
            }
            else
            {
                slidermodel.SliderImage = "yok.jpg";
            }

            Slider slider = new Slider()
            {
                SliderImage = slidermodel.SliderImage,
                SliderUrl = slidermodel.SliderUrl
            };

            sliderRepo.Insert(slider);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Slider slider = sliderRepo.SelectById(id);
            SliderModel slidermodel = new SliderModel()
            {
                SliderId = slider.SliderId,
                SliderImage = slider.SliderImage,
                SliderUrl = slider.SliderUrl

            };

            return View(slidermodel);
        }

        [HttpPost]
        public ActionResult Edit(SliderModel slidermodel, int id, HttpPostedFileBase image)
        {
            if (image != null && image.ContentLength > 0)
            {
                var fileName = Path.GetFileName(image.FileName);
                slidermodel.SliderImage = fileName;
                var path = Path.Combine(Server.MapPath("~/Content/images/slider"), fileName);
                image.SaveAs(path);
            }

            Slider slider = new Slider()
            {
                SliderId = id,
                SliderImage = slidermodel.SliderImage,
                SliderUrl = slidermodel.SliderUrl
            };

            sliderRepo.Update(slider);
            return RedirectToAction("Index");
        }

    }
}