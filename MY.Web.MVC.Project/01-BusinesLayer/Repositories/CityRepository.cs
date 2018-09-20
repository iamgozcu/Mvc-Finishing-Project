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
    public class CityRepository : IRepository<City>
    {
        private readonly MYProjectContext db;
        private readonly IDbSet<City> citys;
        public CityRepository()
        {
            db = new MYProjectContext();
            citys = db.Set<City>();
        }

        public void Delete(City data)
        {
            throw new NotImplementedException();
        }

        public List<City> GetAll()
        {
            List<City> city = new List<City>();
            city = citys.ToList();
            return city;
        }

        public void Insert(City data)
        {
            throw new NotImplementedException();
        }

        public City SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(City data)
        {
            throw new NotImplementedException();
        }
    }
}
