using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.Entity
{
    public class City
    {
        public int CityId { get; set; }
        public int ProvincialIdentificationNo { get; set; }
        public string CityName { get; set; }
        public int CountryId { get; set; }
    }
}
