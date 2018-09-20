using _00_DataAccessLayer.Entity;
using _00_DataAccessLayer.Models;
using _01_BusinesLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BusinesLayer.Repositories
{
    public class ProductCategoryRepository : IRepository<ProductCategory>
    {
        private readonly MYProjectContext db;
        private readonly IDbSet<ProductCategory> productCategories;
        public ProductCategoryRepository()
        {
            db = new MYProjectContext();
            productCategories = db.Set<ProductCategory>();
        }
        public void Delete(ProductCategory data)
        {
            db.Entry(data).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public List<ProductCategory> GetAll()
        {
            List<ProductCategory> productcategory = new List<ProductCategory>();
            productcategory = productCategories.ToList();
            return productcategory;
        }

        public void Insert(ProductCategory data)
        {
            db.Entry(data).State = EntityState.Added;
            db.SaveChanges();
        }

        public ProductCategory SelectById(int id)
        {
            return productCategories.FirstOrDefault(x => x.ProductCategoryId == id);
        }

        public void Update(ProductCategory data)
        {
            db.Entry(data).State = EntityState.Modified;
            db.SaveChanges();
        }

        public List<ProductCategory> GetProductId(int id)
        {
            return productCategories.Where(x => x.ProductId == id).ToList();
        }
        public List<ProductCategory> GetCategoryId(int id)
        {
            List<ProductCategory> prodCat = productCategories.Where(x => x.CategoryId == id).ToList();
            return prodCat;
        }
    }
}
