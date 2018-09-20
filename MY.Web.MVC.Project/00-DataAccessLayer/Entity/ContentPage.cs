using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.Entity
{
    public class ContentPage
    {
        public int PageId { get; set; }
        public string PageName { get; set; }
        public string PageContent { get; set; }
        public string PageImage { get; set; }
    }
}
