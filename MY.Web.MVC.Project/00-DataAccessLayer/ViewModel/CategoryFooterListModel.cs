using _00_DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_DataAccessLayer.ViewModel
{
    public class CategoryFooterListModel
    {
        //Burası Ne İşe Yarar
        public CategoryFooterListModel(Category c, List<Category> sub)
        {
            Category = c;
            if (c == null)
                return;
            SubCategories = sub;
        }
        public Category Category { get; set; }
        public List<Category> SubCategories { get; set; }
    }
}
