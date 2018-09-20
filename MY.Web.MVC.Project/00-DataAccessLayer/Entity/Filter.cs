using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.Entity
{
    public class Filter
    {
        public int FilterId { get; set; }
        public string FilterTitle { get; set; }
        public int CategoryId { get; set; }
    }
}
