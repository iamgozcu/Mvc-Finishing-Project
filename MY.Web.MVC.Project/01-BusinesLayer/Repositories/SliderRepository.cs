using _00_DataAccessLayer.Entity;
using _00_DataAccessLayer.Models;
using _01_BusinesLayer.Interface;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace _01_BusinesLayer.Repositories
{
    public class SliderRepository : IRepository<Slider>
    {
        private readonly MYProjectContext db;
        private readonly IDbSet<Slider> sliders;
        public SliderRepository()
        {
            db = new MYProjectContext();
            sliders = db.Set<Slider>();
        }
        public void Delete(Slider data)
        {
            db.Entry(data).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public List<Slider> GetAll()
        {
            List<Slider> slider = new List<Slider>();
            slider = sliders.ToList();
            return slider;
        }

        public void Insert(Slider data)
        {
            db.Entry(data).State = EntityState.Added;
            db.SaveChanges();
        }

        public Slider SelectById(int id)
        {
            return sliders.FirstOrDefault(x => x.SliderId == id);
        }

        public void Update(Slider data)
        {
            db.Entry(data).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
