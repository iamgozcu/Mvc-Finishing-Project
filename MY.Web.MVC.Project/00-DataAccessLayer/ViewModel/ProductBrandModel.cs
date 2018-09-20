using _00_DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_DataAccessLayer.ViewModel
{
    public class ProductBrandModel
    {
        public ProductBrandModel(Product p, Brand pi)
        {
            Product = p;
            if (p == null)
                return;
            Brand = pi;
        }
        public Product Product { get; set; }
        public Brand Brand { get; set; }
    }
}
