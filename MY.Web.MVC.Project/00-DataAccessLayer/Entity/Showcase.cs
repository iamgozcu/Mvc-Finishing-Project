using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.Entity
{
    public class Showcase
    {
        public int ShowcaseId { get; set; }
        public string ShowcaseName { get; set; }
        public int ShowcaseSortNumber { get; set; }
    }
}
