using _00_DataAccessLayer.Entity;
using _00_DataAccessLayer.Models;

namespace _00_DataAccessLayer.ViewModel
{
    public class ProductListModel
    {
        public ProductListModel(Product p, ProductImage pi)
        {
            Product = p;
            if (p == null)
                return;
            ProductImage = pi;
        }
        public Product Product { get; set; }
        public ProductImage ProductImage { get; set; }
    }
}
