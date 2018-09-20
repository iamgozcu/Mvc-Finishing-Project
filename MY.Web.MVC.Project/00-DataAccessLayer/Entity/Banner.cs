using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.Entity
{
    public class Banner
    {
        public int BannerId { get; set; }
        public string BannerImage { get; set; }
        public string BannerUrl { get; set; }
    }
}
