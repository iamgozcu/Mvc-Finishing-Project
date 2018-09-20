using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.Entity
{
    public class ShowcaseProduct
    {
        public int ShowcaseProductId { get; set; }
        public int ProductId { get; set; }
        public int ShowcaseProductSort { get; set; }
        public int ShowcaseProductTopId { get; set; }
    }
}
