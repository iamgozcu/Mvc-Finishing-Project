using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.Entity
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderTopId { get; set; }
        public int OrderDetailProductId { get; set; }
        public string OrderDetailProductImage { get; set; }
        public string OrderDetailProductName { get; set; }
        public string OrderDetailProductPrice { get; set; }
        public int OrderDetailProductPiece { get; set; }
        public string OrderDetailProductKdv { get; set; }
        public int OrderDetailProductStatus { get; set; }
        public int OrderDetailProductDiscount { get; set; }
    }
}
