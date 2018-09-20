using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.ViewModel
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Adı alanı boş geçilemez!")]
        [DisplayName("Adı")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Ad alanı 2-20 karakter arasında girebilirsiniz.")]
        public string CategoryName { get; set; }
        public int SubCategoryId { get; set; }
        [Required(ErrorMessage = "Aktif Pasif alanı boş geçilemez!")]
        [DisplayName("Aktif Pasif")]
        public bool ActivePassive { get; set; }
        [DisplayName("Kategori Resim")]
        public string CategoryImage { get; set; }
        [DisplayName("Kategori Banner")]
        public string CategoryBanner { get; set; }
        [Required(ErrorMessage = "Seo Url alanı boş geçilemez!")]
        [DisplayName("Seo Url")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Seo url alanı 5-50 karakter arasında girebilirsiniz.")]
        public string ProductGridSeoUrl { get; set; }
    }
}
