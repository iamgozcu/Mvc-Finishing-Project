using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.Entity
{
    public class OrderStatusy
    {
        public int OrderStatuId { get; set; }
        public string OrderStatu { get; set; }
        public string OrderStatuColor { get; set; }
        public bool ActivePassive { get; set; }
    }
}
