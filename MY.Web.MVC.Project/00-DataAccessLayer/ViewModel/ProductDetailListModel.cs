using _00_DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_DataAccessLayer.ViewModel
{
    public class ProductDetailListModel
    {
        public ProductDetailListModel(Product p, List<ProductImage> pi,Brand b)
        {
            Product = p;
            if (p == null)
                return;
            ProductImage = pi;
            Brand = b;
        }
        public Product Product { get; set; }
        public Brand Brand { get; set; }
        public List<ProductImage> ProductImage { get; set; }
    }
}
