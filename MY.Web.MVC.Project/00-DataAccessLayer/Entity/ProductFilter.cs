using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.Entity
{
    public class ProductFilter
    {
        public int ProductFilterId { get; set; }
        public int ProductId { get; set; }
        public int FilterId { get; set; }
    }
}
