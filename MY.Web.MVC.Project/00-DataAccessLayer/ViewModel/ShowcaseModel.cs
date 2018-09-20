using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.ViewModel
{
    public class ShowcaseModel
    {
        [DisplayName("Vitrin No")]
        public int ShowcaseId { get; set; }
        [Required(ErrorMessage = "Vitrin Adı alanı boş geçilemez!")]
        [DisplayName("Vitrin Adı")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Ad alanı 2-20 karakter arasında girebilirsiniz.")]
        public string ShowcaseName { get; set; }
        [Required(ErrorMessage = "Sıralama alanı boş geçilemez!")]
        [DisplayName("Sıralama")]
        public int ShowcaseSortNumber { get; set; }
    }
}
