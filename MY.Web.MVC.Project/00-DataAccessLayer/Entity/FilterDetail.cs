using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.Entity
{
    public class FilterDetail
    {
        public int FilterDetailId { get; set; }
        public string FilterDetailTitle { get; set; }
        public int FilterId { get; set; }
    }
}
