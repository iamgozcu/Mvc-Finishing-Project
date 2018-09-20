using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.Entity
{
    public class CargoDetail
    {
        public int CargoDesiId { get; set; }
        public int CargoParentId { get; set; }
        public int CargoDesiValue { get; set; }
        public string CargoDesiPrice { get; set; }
        public int CargoDesiCityId { get; set; }
    }
}
