using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.Entity
{
    public class District
    {
        public int DistrictId { get; set; }
        public int IndentityNumber { get; set; }
        public string DistrictName { get; set; }
        public int ProvincialIdentificationNo { get; set; }
    }
}
