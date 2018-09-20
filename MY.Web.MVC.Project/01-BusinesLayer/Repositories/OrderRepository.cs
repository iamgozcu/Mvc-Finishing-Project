using _00_DataAccessLayer.Entity;
using _00_DataAccessLayer.Models;
using _00_DataAccessLayer.ViewModel;
using _01_BusinesLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace _01_BusinesLayer.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private readonly MYProjectContext db;
        private readonly IDbSet<Order> orders;
        private readonly OrderStatusiesRepository orderStatusyRepo;
        private readonly VirtualPosBankRepository virtualRepo;

        public OrderRepository()
        {
            db = new MYProjectContext();
            orders = db.Set<Order>();
            orderStatusyRepo = new OrderStatusiesRepository();
            virtualRepo = new VirtualPosBankRepository();
        }

        public void Delete(Order data)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAll()
        {
            List<Order> allOrders = orders.ToList();
            return allOrders;
        }

        public void Insert(Order data)
        {
            throw new NotImplementedException();
        }

        public Order SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Order data)
        {
            throw new NotImplementedException();
        }

        public List<OrderListModel> OrderListModel()
        {
            var list = new List<OrderListModel>();
            foreach (var item in orders)
            {
                OrderStatusy os = orderStatusyRepo.SelectById(Convert.ToInt32(item.OrderStatu));
                VirtualPosBank vpb = virtualRepo.SelectById(Convert.ToInt32(item.OrderPaymentCard));
                list.Add(new OrderListModel(item, os, vpb));
            }

            return list;
        }
    }
}
