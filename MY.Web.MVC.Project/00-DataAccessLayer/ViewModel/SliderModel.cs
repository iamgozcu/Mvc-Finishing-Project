using System.ComponentModel;

namespace _00_DataAccessLayer.ViewModel
{
    public class SliderModel
    {
        [DisplayName("Slider No")]
        public int SliderId { get; set; }
        
        [DisplayName("Slider Fotosu")]
        public string SliderImage { get; set; }
        [DisplayName("Gidilecek Url")]
        public string SliderUrl { get; set; }
    }
}
