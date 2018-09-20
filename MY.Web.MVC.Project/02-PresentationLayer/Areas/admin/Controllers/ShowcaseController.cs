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
    public class ShowcaseController : Controller
    {
        // GET: admin/Showcase

        ShowcaseRepository showcaseRepo = new ShowcaseRepository();
        public ActionResult Index()
        {
            return View(showcaseRepo.GetAll());
        }

        [HttpPost]
        public JsonResult DeleteShowcase(int id)
        {
            Showcase firstbrand = showcaseRepo.SelectById(id);
            if (firstbrand == null)
            {
                return Json(new { success = false, responseText = "Vitrin silinemedi!" }, JsonRequestBehavior.AllowGet);
            }
            showcaseRepo.Delete(firstbrand);
            return Json(new { success = true, responseText = "Vitrin Silme işlemi gerçekleşmiştir." }, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ShowcaseModel showcasemodel)
        {
            Showcase showcase = new Showcase()
            {
                ShowcaseName = showcasemodel.ShowcaseName,
                ShowcaseSortNumber = showcasemodel.ShowcaseSortNumber
            };

            showcaseRepo.Insert(showcase);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Showcase showcase = showcaseRepo.SelectById(id);
            ShowcaseModel showcasemodel = new ShowcaseModel()
            {
                ShowcaseId = showcase.ShowcaseId,
                ShowcaseName = showcase.ShowcaseName,
                ShowcaseSortNumber = showcase.ShowcaseSortNumber

            };

            return View(showcasemodel);
        }

        [HttpPost]
        public ActionResult Edit(ShowcaseModel showcasemodel, int id)
        {
            Showcase showcase = new Showcase()
            {
                ShowcaseId = id,
                ShowcaseName = showcasemodel.ShowcaseName,
                ShowcaseSortNumber = showcasemodel.ShowcaseSortNumber
            };

            showcaseRepo.Update(showcase);
            return RedirectToAction("Index");
        }

    }
}