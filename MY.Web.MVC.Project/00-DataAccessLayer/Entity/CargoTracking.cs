using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.Entity
{
    public class CargoTracking
    {
        public int CargoTrackingId { get; set; }
        public string CargoTrackingNumber { get; set; }
        public string CargoTrackingLink { get; set; }
        public int OrderId { get; set; }
        public int OrderDetailId { get; set; }
    }
}
