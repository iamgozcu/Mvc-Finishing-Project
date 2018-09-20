using _00_DataAccessLayer.Entity;
using _00_DataAccessLayer.Models;
using _01_BusinesLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace _01_BusinesLayer.Repositories
{
    public class OrderStatusiesRepository : IRepository<OrderStatusy>
    {
        private readonly MYProjectContext db;
        private readonly IDbSet<OrderStatusy> orderStatusies;
        public OrderStatusiesRepository()
        {
            db = new MYProjectContext();
            orderStatusies = db.Set<OrderStatusy>();
        }
        public void Delete(OrderStatusy data)
        {
            throw new NotImplementedException();
        }

        public List<OrderStatusy> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(OrderStatusy data)
        {
            throw new NotImplementedException();
        }

        public OrderStatusy SelectById(int id)
        {
            return orderStatusies.FirstOrDefault(x => x.OrderStatuId == id);
        }

        public void Update(OrderStatusy data)
        {
            throw new NotImplementedException();
        }
    }
}
