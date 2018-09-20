using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.Entity
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public DateTime MembershipDate { get; set; }
        public bool ActivePassive { get; set; }
    }
}
