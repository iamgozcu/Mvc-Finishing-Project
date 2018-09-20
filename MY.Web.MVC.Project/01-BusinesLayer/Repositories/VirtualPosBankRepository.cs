using _00_DataAccessLayer.Entity;
using _00_DataAccessLayer.Models;
using _01_BusinesLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace _01_BusinesLayer.Repositories
{
    public class VirtualPosBankRepository : IRepository<VirtualPosBank>
    {
        private readonly MYProjectContext db;
        private readonly IDbSet<VirtualPosBank> virtualPosBank;
        public VirtualPosBankRepository()
        {
            db = new MYProjectContext();
            virtualPosBank = db.Set<VirtualPosBank>();
        }
        public void Delete(VirtualPosBank data)
        {
            throw new NotImplementedException();
        }

        public List<VirtualPosBank> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(VirtualPosBank data)
        {
            throw new NotImplementedException();
        }

        public VirtualPosBank SelectById(int id)
        {
            return virtualPosBank.FirstOrDefault(x => x.BankId == id);
        }

        public void Update(VirtualPosBank data)
        {
            throw new NotImplementedException();
        }
    }
}
