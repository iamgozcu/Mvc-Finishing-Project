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
    public class BannerRepository : IRepository<Banner>
    {
        private readonly MYProjectContext db;
        private readonly IDbSet<Banner> banners;
        public BannerRepository()
        {
            db = new MYProjectContext();
            banners = db.Set<Banner>();
        }
        public void Delete(Banner data)
        {
            db.Entry(data).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public List<Banner> GetAll()
        {
            List<Banner> banner = new List<Banner>();
            banner = banners.ToList();
            return banner;
        }

        public void Insert(Banner data)
        {
            db.Entry(data).State = EntityState.Added;
            db.SaveChanges();
        }

        public Banner SelectById(int id)
        {
            return banners.FirstOrDefault(x => x.BannerId == id);
        }

        public void Update(Banner data)
        {
            db.Entry(data).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
