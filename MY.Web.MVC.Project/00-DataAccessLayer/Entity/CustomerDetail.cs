using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.Entity
{
    public class CustomerDetail
    {
        public int CustomerDetailId { get; set; }
        public string CustomerDetailName { get; set; }
        public string CustomerDetailSurname { get; set; }
        public string EmailAdress { get; set; }
        public string AddressName { get; set; }
        public string CompanyName { get; set; }
        public string TaxAdministration { get; set; }
        public string TaxNumber { get; set; }
        public string Phone { get; set; }
        public string GSM { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public int CustomerId { get; set; }
    }
}
