using _01_BusinesLayer.Repositories;
using System.Web.Mvc;

namespace _02_PresentationLayer.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryRepository categoryRepo = new CategoryRepository();
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult TopCategoryPartial()
        {
            return View(categoryRepo.GetTopSubCategoryId0());
        }

        [ChildActionOnly]
        public ActionResult FooterCategoryPartial()
        {
            return View(categoryRepo.GetFooterSubCategoryId0());
        }
    }
}