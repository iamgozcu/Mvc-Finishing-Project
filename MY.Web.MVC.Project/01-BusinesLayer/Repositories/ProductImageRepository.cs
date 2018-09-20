using _00_DataAccessLayer.Entity;
using _00_DataAccessLayer.Models;
using _01_BusinesLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace _01_BusinesLayer.Repositories
{
    public class ProductImageRepository : IRepository<ProductImage>
    {
        private readonly MYProjectContext db;
        private readonly IDbSet<ProductImage> productImages;
        public ProductImageRepository()
        {
            db = new MYProjectContext();
            productImages = db.Set<ProductImage>();
        }

        public void Delete(ProductImage data)
        {
            db.Entry(data).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public List<ProductImage> GetAll()
        {
            throw new NotImplementedException();
        }


        public void Insert(ProductImage data)
        {
            db.Entry(data).State = EntityState.Added;
            db.SaveChanges();
        }

        public ProductImage SelectById(int id)
        {
            return productImages.FirstOrDefault(x => x.ImageId == id);
        }

        public void Update(ProductImage data)
        {
            throw new NotImplementedException();
        }
        public ProductImage FirstByProductId(int id)
        {
            return productImages.FirstOrDefault(x => x.ProductId == id);
        }
        public List<ProductImage> FirstByProductImageId(int id)
        {
            return productImages.Where(x => x.ProductId == id).ToList();
        }
    }
}