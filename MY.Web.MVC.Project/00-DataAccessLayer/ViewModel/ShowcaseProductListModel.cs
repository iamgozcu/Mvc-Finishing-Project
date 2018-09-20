using _00_DataAccessLayer.Entity;
using System.Collections.Generic;

namespace _00_DataAccessLayer.ViewModel
{
    public class ShowcaseProductListModel
    {
        public List<Showcase> Showcase { get; set; }
        public List<ShowcaseProduct> ShowcaseProduct { get; set; }
        public List<Product> Product { get; set; }
        public List<ProductImage> ProductImage { get; set; }
    }
}
