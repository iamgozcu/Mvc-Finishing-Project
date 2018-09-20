using _01_BusinesLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_PresentationLayer.Controllers
{
    public class ProductGridController : Controller
    {
        // GET: ProductGrid
        ProductRepository productRepo= new ProductRepository();
        CategoryRepository categoryRepo = new CategoryRepository();
        public ActionResult Index(string ProductGridSeoUrl)
        {
            return View(productRepo.ProductCategoryList(ProductGridSeoUrl));
        }

        [ChildActionOnly]
        public ActionResult ClickedCategoryPartial(string ProductGridSeoUrl)
        {
            return View(categoryRepo.GetAllFirstCat(ProductGridSeoUrl));
        }

        [ChildActionOnly]
        public ActionResult ClickedCategorySubPartial(string ProductGridSeoUrl)
        {
            return View(productRepo.ProductCategoryList(ProductGridSeoUrl));
        }

        [ChildActionOnly]
        public ActionResult ClickedCategoryUstPartial(string ProductGridSeoUrl)
        {
            return View(productRepo.ProductCategorySubList(ProductGridSeoUrl));
        }

        [ChildActionOnly]
        public ActionResult ClickedCategoryBannerPartial(string ProductGridSeoUrl)
        {
            return View(categoryRepo.GetAllFirstCat(ProductGridSeoUrl));
        }

        [ChildActionOnly]
        public ActionResult ClickedProductCategoryPartial(string ProductGridSeoUrl)
        {
            return View(productRepo.ProductListModel1(ProductGridSeoUrl));
        }

        [ChildActionOnly]
        public ActionResult ClickedProductCategoryListPartial(string ProductGridSeoUrl)
        {
            return View(productRepo.ProductListModel1(ProductGridSeoUrl));
        }
        [ChildActionOnly]
        public ActionResult ClickedProductBrandListPartial(string ProductGridSeoUrl)
        {
            return View(productRepo.ProductGridBrand(ProductGridSeoUrl));
        }
    }
}