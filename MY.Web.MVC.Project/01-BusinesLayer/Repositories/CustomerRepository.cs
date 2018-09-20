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
    public class CustomerRepository : IRepository<Customer>
    {
        private readonly MYProjectContext db;
        private readonly IDbSet<Customer> customers;
        public CustomerRepository()
        {
            db = new MYProjectContext();
            customers = db.Set<Customer>();
        }

        public void Delete(Customer data)
        {
            db.Entry(data).State = EntityState.Deleted;
            db.SaveChanges();
        }

        public List<Customer> GetAll()
        {
            List<Customer> customer = new List<Customer>();
            customer = customers.ToList();
            return customer;
        }

        public void Insert(Customer data)
        {
            Customer emailControl=customers.FirstOrDefault(x => x.EmailAddress == data.EmailAddress);
            if (emailControl==null)
            {
                db.Entry(data).State = EntityState.Added;
                db.SaveChanges();
            }
            
        }

        public Customer SelectById(int id)
        {
            return customers.FirstOrDefault(x => x.CustomerId == id);
        }

    
        public void Update(Customer data)
        {
            db.Entry(data).State = EntityState.Modified;
            db.SaveChanges();
        }

        public Customer CustomerLogin(UserLoginModel c)
        {
            var uye = (from i in customers where i.Password == c.Password && i.EmailAddress == c.EmailAddress select i).SingleOrDefault();
            Customer customer = uye;
            return customer;
        }

        public Customer SelectByEmail(string email)
        {
            return customers.FirstOrDefault(x => x.EmailAddress == email);
        }

    }
}
