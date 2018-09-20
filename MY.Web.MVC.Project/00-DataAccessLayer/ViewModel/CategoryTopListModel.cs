using _00_DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_DataAccessLayer.ViewModel
{
    public class CategoryTopListModel
    {
        public CategoryTopListModel(Category c, Category sub, List<Category> sub2)
        {
            Category = c;
            if (c == null)
                return;
            SubCategories = sub;
            SubCategories2 = sub2;
        }
        public CategoryTopListModel(Category sub0, List<Category> sub1)
        {
            Category = sub0;
            if (sub0 == null)
                return;
            SubCategories2 = sub1;
        }

        public CategoryTopListModel()
        {

        }

        public Category Category { get; set; }
        public Category SubCategories { get; set; }
        public List<Category> SubCategories2 { get; set; }
    }
}
