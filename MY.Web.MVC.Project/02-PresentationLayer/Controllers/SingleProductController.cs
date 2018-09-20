using _01_BusinesLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02_PresentationLayer.Controllers
{
    public class SingleProductController : Controller
    {
        // GET: SingleProduct
        ProductRepository prod = new ProductRepository();
        public ActionResult Index(string SeoUrl)
        {
            return View(prod.ProductDetailListModel(SeoUrl));
        }

    }
}