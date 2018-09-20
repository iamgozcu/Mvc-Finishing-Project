using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.Entity
{
    public class Town
    {
        public int TownId { get; set; }
        public int DistrictIdNumber { get; set; }
        public int BucakIdNumber { get; set; }
        public int TownIdNumber { get; set; }
        public int IdNumber { get; set; }
        public string TownName { get; set; }
    }
}
