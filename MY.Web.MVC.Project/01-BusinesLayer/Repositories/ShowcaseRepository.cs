using _00_DataAccessLayer.Entity;
using _00_DataAccessLayer.Models;
using _00_DataAccessLayer.ViewModel;
using _01_BusinesLayer.Interface;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace _01_BusinesLayer.Repositories
{
    public class ShowcaseRepository : IRepository<Showcase>
    {
        private readonly MYProjectContext db;
        private readonly IDbSet<Showcase> showcases;
        public ShowcaseRepository()
        {
            db = new MYProjectContext();
            showcases = db.Set<Showcase>();
           
        }
        public void Delete(Showcase data)
        {
            db.Entry(data).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public List<Showcase> GetAll()
        {
            List<Showcase> showcase = new List<Showcase>();
            showcase = showcases.ToList();
            return showcase;
        }

        public void Insert(Showcase data)
        {
            db.Entry(data).State = EntityState.Added;
            db.SaveChanges();
        }

        public Showcase SelectById(int id)
        {
            return showcases.FirstOrDefault(x => x.ShowcaseId == id);
        }

        public void Update(Showcase data)
        {
            db.Entry(data).State = EntityState.Modified;
            db.SaveChanges();
        }

      
    }
}
