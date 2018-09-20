using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.Entity
{
    public class FilterProduct
    {
        public int FilterProductId { get; set; }
        public int FilterDetailId { get; set; }
        public int ProductId { get; set; }
    }
}
