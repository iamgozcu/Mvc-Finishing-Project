using _00_DataAccessLayer.Entity;
using _00_DataAccessLayer.ViewModel;
using _01_BusinesLayer.Repositories;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace _02_PresentationLayer.Areas.admin.Controllers
{
    public class BrandController : Controller
    {
        // GET: admin/Brand
        BrandRepository brandRepo = new BrandRepository();
        public ActionResult Index()
        {
            return View(brandRepo.GetAll());
        }

        [HttpPost]
        public JsonResult DeleteBrand(int id)
        {
            Brand firstbrand = brandRepo.SelectById(id);
            if (firstbrand == null)
            {
                return Json(new { success = false, responseText = "Marka silinemedi!" }, JsonRequestBehavior.AllowGet);
            }
            brandRepo.Delete(firstbrand);
            return Json(new { success = true, responseText = "Marka Silme işlemi gerçekleşmiştir." }, JsonRequestBehavior.AllowGet);

        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(BrandModel brandmodel, HttpPostedFileBase image)
        {
            if (image != null && image.ContentLength > 0)
            {
                var fileName = Path.GetFileName(image.FileName);
                brandmodel.BrandImage = fileName;
                var path = Path.Combine(Server.MapPath("~/Content/images/brands"), fileName);
                image.SaveAs(path);
            }
            else
            {
                brandmodel.BrandImage = "yok.jpg";
            }

            Brand brand = new Brand()
            {
                BrandName = brandmodel.BrandName,
                BrandImage = brandmodel.BrandImage,
                Sorting = brandmodel.Sorting,
                ActivePassive = true
            };

            brandRepo.Insert(brand);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Brand brand = brandRepo.SelectById(id);
            BrandModel brandmodel = new BrandModel()
            {
                BrandId = brand.BrandId,
                BrandName = brand.BrandName,
                BrandImage = brand.BrandImage,
                Sorting = brand.Sorting,
                ActivePassive = brand.ActivePassive

            };

            return View(brandmodel);
        }

        [HttpPost]
        public ActionResult Edit(BrandModel brandmodel,int id, HttpPostedFileBase image)
        {
            if (image != null && image.ContentLength > 0)
            {
                var fileName = Path.GetFileName(image.FileName);
                brandmodel.BrandImage = fileName;
                var path = Path.Combine(Server.MapPath("~/Content/images/brands"), fileName);
                image.SaveAs(path);
            }

            Brand brand = new Brand()
            {
                BrandId = id,
                BrandName = brandmodel.BrandName,
                BrandImage = brandmodel.BrandImage,
                Sorting = brandmodel.Sorting,
                ActivePassive = brandmodel.ActivePassive
            };

            brandRepo.Update(brand);
            return RedirectToAction("Index");
        }

    }
}