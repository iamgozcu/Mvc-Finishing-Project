using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.Entity
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int SubCategoryId { get; set; }
        public bool ActivePassive { get; set; }
        public string CategoryImage { get; set; }
        public string CategoryBanner { get; set; }
        public string ProductGridSeoUrl { get; set; }
    }
}
