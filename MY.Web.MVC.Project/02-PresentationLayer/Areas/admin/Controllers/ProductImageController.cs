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
    public class ProductImageController : Controller
    {
        // GET: admin/ProductImage
        ProductImageRepository productImageRepo = new ProductImageRepository();
        ProductRepository productRepo = new ProductRepository();

        public ActionResult Index(int productImageId)
        {
            List<ProductImage> productImageList = productImageRepo.FirstByProductImageId(productImageId);
            return View(productImageList);
        }

        [HttpPost]
        public JsonResult DeleteProductImage(int id)
        {
            ProductImage firstProductImage= productImageRepo.SelectById(id);
            if (firstProductImage == null)
            {
                return Json(new { success = false, responseText = "Ürün resmi silinemedi!" }, JsonRequestBehavior.AllowGet);
            }
            productImageRepo.Delete(firstProductImage);
            return Json(new { success = true, responseText = "Ürün resmi Silme işlemi gerçekleşmiştir." }, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public ActionResult Create(int productImageId)
        {
            Product productImage = productRepo.SelectById(productImageId);
            return View(productImage);
        }
        [HttpPost]
        public ActionResult Create(HttpPostedFileBase image, Product productImageId)
          {
            ProductImage prodImage = new ProductImage();
            if (image != null && image.ContentLength > 0)
            {
                var fileName = Path.GetFileName(image.FileName);
                prodImage.Path = fileName;
                var path = Path.Combine(Server.MapPath("~/Content/images/products"), fileName);
                image.SaveAs(path);
            }
            else
            {
                return RedirectToAction("Create", "ProductImage", new { productImageId = productImageId.ProductId });
            }

            ProductImage productImage = new ProductImage()
            {
                Path = prodImage.Path,
                ProductId= productImageId.ProductId,
                CreatedDate=DateTime.Now
            };

            productImageRepo.Insert(productImage);
            return RedirectToAction("Index", "ProductImage", new { productImageId = productImageId.ProductId });
        }
    }
}