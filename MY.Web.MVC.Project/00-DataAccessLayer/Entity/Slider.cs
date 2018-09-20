using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.Entity
{
    public class Slider
    {
        public int SliderId { get; set; }
        public string SliderImage { get; set; }
        public string SliderUrl { get; set; }
    }
}
