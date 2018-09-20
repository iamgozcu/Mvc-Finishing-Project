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
    public class DistrictRepository : IRepository<District>
    {
        private readonly MYProjectContext db;
        private readonly IDbSet<District> districts;

        public DistrictRepository()
        {
            db = new MYProjectContext();
            districts = db.Set<District>();
        }
        public void Delete(District data)
        {
            throw new NotImplementedException();
        }

        public List<District> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(District data)
        {
            throw new NotImplementedException();
        }

        public District SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(District data)
        {
            throw new NotImplementedException();
        }

        public List<District> GetAllCityId(int id)
        {
            return districts.Where(x => x.ProvincialIdentificationNo == id).ToList();
        }
    }
}
