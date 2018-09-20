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
    public class CategoryController : Controller
    {
        // GET: admin/Category


        CategoryRepository categoryRepo = new CategoryRepository();
        ProductCategoryRepository productCategoryRepo = new ProductCategoryRepository();

        [HttpGet]
        public ActionResult Index(string id)
        {
            return View(CategoryList(id));
        }

        public List<Category> CategoryList(string id)
        {
            List<Category> catList = new List<Category>();
            catList = categoryRepo.GetAllFirst(id);
            return catList;
        }

        [HttpPost]
        public JsonResult DeleteCategory(int id)
        {
            Category firstcat = categoryRepo.SelectById(id);
            Category subId = categoryRepo.SelectSubId(firstcat.CategoryId);
            List<ProductCategory> productCategory = productCategoryRepo.GetCategoryId(firstcat.CategoryId);
            if (subId != null)
            {
                return Json(new { success = false, responseText = "Bu kategoriyi silmek için önce alt kategorilerini siliniz!" }, JsonRequestBehavior.AllowGet);
            }


            if (productCategory.Count > 0)
            {
                foreach (var item in productCategory)
                {
                    productCategoryRepo.Delete(item);
                }
            }
            categoryRepo.Delete(firstcat);
            return Json(new { success = true, responseText = "Silme işlemi gerçekleşmiştir." }, JsonRequestBehavior.AllowGet);

        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CategoryModel catModel, string id, HttpPostedFileBase image, HttpPostedFileBase banner)
        {
            int catId = Convert.ToInt32(id);
            catModel.SubCategoryId = catId;

            if (image != null && image.ContentLength > 0)
            {
                var fileName = Path.GetFileName(image.FileName);
                catModel.CategoryImage = fileName;
                var path = Path.Combine(Server.MapPath("~/Content/images/category"), fileName);
                image.SaveAs(path);
            }
            else
            {
                catModel.CategoryImage = "yok.jpg";
            }

            if (banner != null && banner.ContentLength > 0)
            {
                var fileName = Path.GetFileName(banner.FileName);
                catModel.CategoryBanner = fileName;
                var path = Path.Combine(Server.MapPath("~/Content/images/categoryBanner/"), fileName);
                banner.SaveAs(path);
            }
            else
            {
                catModel.CategoryBanner = "yok.jpg";
            }

            Category category = new Category()
            {
                CategoryName = catModel.CategoryName,
                SubCategoryId = catModel.SubCategoryId,
                ActivePassive = catModel.ActivePassive,
                CategoryImage = catModel.CategoryImage,
                CategoryBanner = catModel.CategoryBanner,
                ProductGridSeoUrl = catModel.ProductGridSeoUrl
            };


            categoryRepo.Insert(category);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            Category cat = categoryRepo.SelectById(id);
            CategoryModel catmodel = new CategoryModel()
            {
                CategoryId = cat.CategoryId,
                CategoryName = cat.CategoryName,
                SubCategoryId = cat.SubCategoryId,
                ActivePassive = cat.ActivePassive,
                CategoryImage = cat.CategoryImage,
                CategoryBanner = cat.CategoryBanner,
                ProductGridSeoUrl = cat.ProductGridSeoUrl

            };

            return View(catmodel);
        }

        [HttpPost]
        public ActionResult Edit(CategoryModel catModel, int id, HttpPostedFileBase image, HttpPostedFileBase banner)
        {
           // int subid = Convert.ToInt32(Request.QueryString["subCatId"].ToString());
            if (image != null && image.ContentLength > 0)
            {
                var fileName = Path.GetFileName(image.FileName);
                catModel.CategoryImage = fileName;
                var path = Path.Combine(Server.MapPath("~/Content/images/category/"), fileName);
                image.SaveAs(path);
            }
          

            if (banner != null && banner.ContentLength > 0)
            {
                var fileName = Path.GetFileName(banner.FileName);
                catModel.CategoryBanner = fileName;
                var path = Path.Combine(Server.MapPath("~/Content/images/categoryBanner/"), fileName);
                banner.SaveAs(path);
            }


            Category category = new Category()
            {
                CategoryId = id,
                CategoryName = catModel.CategoryName,
                ActivePassive = catModel.ActivePassive,
                CategoryImage = catModel.CategoryImage,
                CategoryBanner = catModel.CategoryBanner,
                ProductGridSeoUrl = catModel.ProductGridSeoUrl,
                SubCategoryId= catModel.SubCategoryId
            };

            categoryRepo.Update(category);
            return RedirectToAction("Index");
        }


        public JsonResult EditById(int id)
        {
            Category cat = categoryRepo.SelectById(id);
            CategoryModel catmodel = new CategoryModel()
            {
                CategoryId = cat.CategoryId,
                CategoryName = cat.CategoryName,
                SubCategoryId = cat.SubCategoryId,
                ActivePassive = cat.ActivePassive,
                CategoryImage = cat.CategoryImage,
                CategoryBanner = cat.CategoryBanner,
                ProductGridSeoUrl = cat.ProductGridSeoUrl

            };

            return Json(catmodel, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult UpdateCategoryy(CategoryModel catModel, int id, HttpPostedFileBase image, HttpPostedFileBase banner)
        {
            if (image != null && image.ContentLength > 0)
            {
                var fileName = Path.GetFileName(image.FileName);
                catModel.CategoryImage = fileName;
                var path = Path.Combine(Server.MapPath("~/Content/images/category/"), fileName);
                image.SaveAs(path);
            }


            if (banner != null && banner.ContentLength > 0)
            {
                var fileName = Path.GetFileName(banner.FileName);
                catModel.CategoryBanner = fileName;
                var path = Path.Combine(Server.MapPath("~/Content/images/categoryBanner/"), fileName);
                banner.SaveAs(path);
            }


            Category category = new Category()
            {
                CategoryId = id,
                CategoryName = catModel.CategoryName,
                ActivePassive = catModel.ActivePassive,
                CategoryImage = catModel.CategoryImage,
                CategoryBanner = catModel.CategoryBanner,
                ProductGridSeoUrl = catModel.ProductGridSeoUrl
            };

            categoryRepo.Update(category);
            return Json(new { success = true, responseText = "Güncelleme işlemi gerçekleşmiştir." }, JsonRequestBehavior.AllowGet);

        }

    }
}