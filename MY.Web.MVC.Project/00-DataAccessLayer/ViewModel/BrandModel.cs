using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.ViewModel
{
    public class BrandModel
    {
        [DisplayName("Marka No")]
        public int BrandId { get; set; }
        [Required(ErrorMessage = "Marka Adı alanı boş geçilemez!")]
        [DisplayName("Marka Adı")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Ad alanı 2-20 karakter arasında girebilirsiniz.")]
        public string BrandName { get; set; }
        [DisplayName("Marka Fotosu")]
        public string BrandImage { get; set; }
        [DisplayName("Pasif Aktif")]
        public bool ActivePassive { get; set; }
        [Required(ErrorMessage = "Sıralama alanı boş geçilemez!")]
        [DisplayName("Sıralama")]
        public int Sorting { get; set; }
    }
}
