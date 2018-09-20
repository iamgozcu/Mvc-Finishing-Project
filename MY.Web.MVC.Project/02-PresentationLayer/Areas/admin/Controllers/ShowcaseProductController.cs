using _00_DataAccessLayer.Entity;
using _00_DataAccessLayer.ViewModel;
using _01_BusinesLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace _02_PresentationLayer.Areas.admin.Controllers
{
    public class ShowcaseProductController : Controller
    {
        // GET: admin/ShowcaseProduct
        ProductRepository productRepo = new ProductRepository();
        ShowcaseProductRepository showcaseProductRepo = new ShowcaseProductRepository();
        public ActionResult Index(int showcaseId)
        {
            List<ProductListModel> productList = productRepo.ShowcaseProductListModel(showcaseId);
            return View(productList);
        }

        [HttpPost]
        public JsonResult DeleteShowcaseProduct(int id, string showcaseId)
        {
            ShowcaseProduct firstbrand = showcaseProductRepo.SelectByShowcaseProductId(id, showcaseId);
            if (firstbrand == null)
            {
                return Json(new { success = false, responseText = "Vitrinden ürün silinemedi!" }, JsonRequestBehavior.AllowGet);
            }
            showcaseProductRepo.Delete(firstbrand);
            return Json(new { success = true, responseText = "Vitrin ürünü Silme işlemi gerçekleşmiştir." }, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(productRepo.ProductListModel());
        }

        [HttpPost]
        public JsonResult CreateShowcaseProduct(int id, string showcaseId)
        {
            ShowcaseProduct firstbrand = showcaseProductRepo.SelectByShowcaseProductId(id, showcaseId);
            if (firstbrand != null)
            {
                return Json(new { success = false, responseText = "Bu ürün eklemek istediğiniz vitrinde zaten mevcut!" }, JsonRequestBehavior.AllowGet);
            }

            int ShowcaseID = Convert.ToInt32(showcaseId);
            ShowcaseProduct showcaseProduct = new ShowcaseProduct()
            {
                ProductId = id,
                ShowcaseProductTopId = ShowcaseID
            };

            if (showcaseProduct.ProductId == 0)
            {
                return Json(new { success = false, responseText = "Vitrine ürün eklenemedi!" }, JsonRequestBehavior.AllowGet);

            }

            if (showcaseProduct.ShowcaseProductTopId == 0)
            {
                return Json(new { success = false, responseText = "Vitrine ürün eklenemedi!" }, JsonRequestBehavior.AllowGet);

            }

            showcaseProductRepo.Insert(showcaseProduct);
            return Json(new { success = true, responseText = "Vitrin ürüne ekleme işlemi gerçekleşmiştir." }, JsonRequestBehavior.AllowGet);

        }
    }
}