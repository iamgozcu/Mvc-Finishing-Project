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
    public class ProductController : Controller
    {
        ProductRepository productRepo = new ProductRepository();
        BrandRepository brandRepo = new BrandRepository();
        ShowcaseProductRepository showcaseProductRepo = new ShowcaseProductRepository();
        ProductCategoryRepository productCategoryRepo = new ProductCategoryRepository();

        // GET: admin/Product
        public ActionResult Index()
        {
            return View(productRepo.ProductListModel());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProductModel product)
        {

            Product p = new Product();
            p.ProductName = product.ProductName;
            p.SeoUrl = product.SeoUrl;
            p.ProductPrice = product.ProductPrice;
            p.ReferralPrice = product.ReferralPrice;
            p.Rsp = product.Rsp;
            p.ProductShortDescription = product.ProductShortDescription;
            p.CreatedDate = DateTime.Now;
            p.BrandId = product.BrandId;
            p.ProductCategory = 1;
            p.ProductDescription = product.ProductDescription;
            p.ActivePassive = true;
            p.ProductHit = 0;
            p.Sku = product.Sku;
            p.Stock = product.Stock;
            p.WatCode = product.WatCode;
            p.ProductCriterion = product.ProductCriterion;
            p.EndDate = DateTime.Now;
            p.SpeacilPrice = product.SpeacilPrice;
            p.MustStockLine = product.MustStockLine;
            p.Por = "";
            p.BarcodeCode = product.BarcodeCode;
            p.UpdateDate = DateTime.Now;
            p.CargoPrice = product.CargoPrice;
            p.N11 = product.N11;
            productRepo.Insert(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Product prod = productRepo.SelectById(id);
            ProductModel prodmodel = new ProductModel()
            {
                ProductId = prod.ProductId,
                ProductName = prod.ProductName,
                SeoUrl = prod.SeoUrl,
                ProductPrice = prod.ProductPrice,
                ReferralPrice = prod.ReferralPrice,
                Rsp = prod.Rsp,
                ProductShortDescription = prod.ProductShortDescription,
                CreatedDate = prod.CreatedDate,
                BrandId = prod.BrandId,
                ProductDescription = prod.ProductDescription,
                ActivePassive = prod.ActivePassive,
                ProductHit = prod.ProductHit,
                Sku = prod.Sku,
                Stock = prod.Stock,
                WatCode = prod.WatCode,
                ProductCriterion = prod.ProductCriterion,
                EndDate = prod.EndDate,
                SpeacilPrice = prod.SpeacilPrice,
                MustStockLine = prod.MustStockLine,
                Por = prod.Por,
                BarcodeCode = prod.BarcodeCode,
                UpdateDate = prod.UpdateDate,
                CargoPrice = prod.CargoPrice,
                N11 = prod.N11
            };

            return View(prodmodel);
        }

        [HttpPost]
        public ActionResult Edit(ProductModel product, int id)
        {

            Product p = new Product();
            p.ProductId = id;
            p.ProductName = product.ProductName;
            p.SeoUrl = product.SeoUrl;
            p.ProductPrice = product.ProductPrice;
            p.ReferralPrice = product.ReferralPrice;
            p.Rsp = product.Rsp;
            p.ProductShortDescription = product.ProductShortDescription;
            p.CreatedDate = DateTime.Now;
            p.BrandId = product.BrandId;
            p.ProductCategory = 1;
            p.ProductDescription = product.ProductDescription;
            p.ActivePassive = true;
            p.ProductHit = 0;
            p.Sku = product.Sku;
            p.Stock = product.Stock;
            p.WatCode = product.WatCode;
            p.ProductCriterion = product.ProductCriterion;
            p.EndDate = DateTime.Now;
            p.SpeacilPrice = product.SpeacilPrice;
            p.MustStockLine = product.MustStockLine;
            p.Por = "";
            p.BarcodeCode = product.BarcodeCode;
            p.UpdateDate = DateTime.Now;
            p.CargoPrice = product.CargoPrice;
            p.N11 = product.N11;
            productRepo.Update(p);
            return RedirectToAction("Index");
        }


        [ChildActionOnly]
        public ActionResult CreateBrandDropdownPartial()
        {
            List<Brand> listbrand = brandRepo.GetAll();
            ViewBag.BrandList = listbrand;
            return View();
        }



        [HttpPost]
        public JsonResult DeleteProduct(int id)
        {
            Product firstprod = productRepo.SelectById(id);
            List<ShowcaseProduct> showcaseProduct = showcaseProductRepo.GetProductId(firstprod.ProductId);
            List<ProductCategory> productCategory = productCategoryRepo.GetProductId(firstprod.ProductId);

            if (firstprod == null)
            {
                return Json(new { success = false, responseText = "Ürün silinirken hata oluştu!" }, JsonRequestBehavior.AllowGet);
            }
            if (showcaseProduct.Count > 0)
            {
                foreach (var item in showcaseProduct)
                {
                    showcaseProductRepo.Delete(item);
                }
            }
            if (productCategory.Count > 0)
            {
                foreach (var item in productCategory)
                {
                    productCategoryRepo.Delete(item);
                }

            }
            productRepo.Delete(firstprod);

            return Json(new { success = true, responseText = "Silme işlemi gerçekleşmiştir." }, JsonRequestBehavior.AllowGet);

        }
    }
}