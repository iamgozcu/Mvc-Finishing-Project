using _00_DataAccessLayer.Entity;
using _00_DataAccessLayer.Models;

namespace _00_DataAccessLayer.ViewModel
{
    public class OrderListModel
    {
        public OrderListModel(Order o, OrderStatusy os, VirtualPosBank vpb)
        {
            Order = o;
            if (o == null)
                return;
            OrderStatusy = os;
            VirtualPosBank = vpb;

        }
        public Order Order { get; set; }
        public OrderStatusy OrderStatusy { get; set; }
        public VirtualPosBank VirtualPosBank { get; set; }
    }
}
