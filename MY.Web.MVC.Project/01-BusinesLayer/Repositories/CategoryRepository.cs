using _00_DataAccessLayer.Entity;
using _00_DataAccessLayer.Models;
using _00_DataAccessLayer.ViewModel;
using _01_BusinesLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace _01_BusinesLayer.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private readonly MYProjectContext db;
        private readonly IDbSet<Category> categories;
        private readonly IDbSet<CategoryModel> categoryModel;
        public CategoryRepository()
        {
            db = new MYProjectContext();
            categories = db.Set<Category>();
            categoryModel = db.Set<CategoryModel>();
        }
        public void Delete(Category data)
        {
            db.Entry(data).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public List<Category> GetAll()
        {
            List<Category> cat = new List<Category>();
            cat = categories.ToList();
            return cat;
        }


        public List<Category> GetAllFirst(string subCatId)
        {
            int id = Convert.ToInt32(subCatId);
            List<Category> cat = new List<Category>();
            cat = categories.Where(x => x.SubCategoryId == id).ToList();
            return cat;
        }
       

        public void Insert(Category data)
        {
            db.Entry(data).State = EntityState.Added;
            db.SaveChanges();
        }

        public Category SelectById(int id)
        {
            return categories.FirstOrDefault(x => x.CategoryId == id);
        }
        public Category SelectSubId(int id)
        {
            return categories.FirstOrDefault(x => x.SubCategoryId == id);
        }

        public void Update(Category data)
        {
            db.Entry(data).State = EntityState.Modified;
            db.SaveChanges();
        }

        public List<CategoryTopListModel> GetTopSubCategoryId0()
        {
            var list = new List<CategoryTopListModel>();
            List<Category> categories = this.categories.Where(x => x.SubCategoryId == 0).ToList();
            foreach (var category in categories)
            {
                List<Category> subcats = this.categories.Where(x => x.SubCategoryId == category.CategoryId).ToList();
                list.Add(new CategoryTopListModel(category, subcats));
            }

            return list;
        }

       
        public List<CategoryFooterListModel> GetFooterSubCategoryId0()
        {
            var list = new List<CategoryFooterListModel>();
            
            List<Category> categories = this.categories.Where(x => x.SubCategoryId == 0).Take(2).ToList();
            foreach (var category in categories)
            {
                List<Category> subcats = this.categories.Where(x => x.SubCategoryId == category.CategoryId).ToList();
                list.Add(new CategoryFooterListModel(category, subcats));
            }

            return list;
        }

        public Category GetAllFirstCat(string seourl)
        {
            Category cat = new Category();
            cat = categories.Where(x => x.ProductGridSeoUrl== seourl).FirstOrDefault();
            return cat;
        }

        public List<Category> GetAllFirstCat1(int id)
        {
            List<Category> cat1 = new List<Category>();
            cat1 = categories.Where(x => x.SubCategoryId == id).ToList();
            return cat1;
        }
        public Category GetAllFirstSubCat1(int id)
        {
            Category cat1 = new Category();
            cat1 = categories.Where(x => x.CategoryId == id).FirstOrDefault();
            return cat1;
        }
    }
}
