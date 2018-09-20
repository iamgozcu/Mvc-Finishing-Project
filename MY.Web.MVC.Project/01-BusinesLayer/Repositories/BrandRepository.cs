using _00_DataAccessLayer.Entity;
using _00_DataAccessLayer.Models;
using _01_BusinesLayer.Interface;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace _01_BusinesLayer.Repositories
{
    public class BrandRepository : IRepository<Brand>
    {
        private readonly MYProjectContext db;
        private readonly IDbSet<Brand> brands;
        public BrandRepository()
        {
            db = new MYProjectContext();
            brands = db.Set<Brand>();
        }

        public void Delete(Brand data)
        {
            db.Entry(data).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public List<Brand> GetAll()
        {
            List<Brand> brand = new List<Brand>();
            brand = brands.ToList();
            return brand;
        }
        public void Insert(Brand data)
        {
            db.Entry(data).State = EntityState.Added;
            db.SaveChanges();
        }

        public Brand SelectById(int id)
        {
            return brands.FirstOrDefault(x => x.BrandId == id);
        }

        public void Update(Brand data)
        {
            db.Entry(data).State = EntityState.Modified;
            db.SaveChanges();
        }
        public List<Brand> GetAllFirstBrand(int id)
        {
            List<Brand> brand = new List<Brand>();
            brand = brands.Where(x=>x.BrandId==id).ToList();
            return brand;
        }
    }
}
