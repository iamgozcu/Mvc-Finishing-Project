using _00_DataAccessLayer.Entity;
using _00_DataAccessLayer.Models;
using _00_DataAccessLayer.ViewModel;
using _01_BusinesLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BusinesLayer.Repositories
{
    public class AdministratorRepository : IRepository<Administrator>
    {
        private readonly MYProjectContext db;
        private readonly IDbSet<Administrator> administrators;
        public AdministratorRepository()
        {
            db = new MYProjectContext();
            administrators = db.Set<Administrator>();
        }
        public void Delete(Administrator data)
        {
            throw new NotImplementedException();
        }

        public List<Administrator> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Administrator data)
        {
            throw new NotImplementedException();
        }

        public Administrator SelectById(int id)
        {
            return administrators.FirstOrDefault(x => x.AdminId == id);
        }

        public void Update(Administrator data)
        {
            throw new NotImplementedException();
        }

        public Administrator AdministratorLogin(AdminLoginModel a)
        {
            var admin = (from i in administrators where i.Password == a.Password && i.UserName == a.UserName select i).SingleOrDefault();
            Administrator administrator = admin;
            return administrator;
        }
    }
}
