using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.ViewModel
{
    public class AdminLoginModel
    {
        [Required(ErrorMessage = "Kullanıcı Adı alanı boş geçilemez")]
        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifre alanı boş geçilemez")]
        [DisplayName("Şifre")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Şifre alanı en az 5 karakterli olmak zorundadır")]
        public string Password { get; set; }
    }
}
