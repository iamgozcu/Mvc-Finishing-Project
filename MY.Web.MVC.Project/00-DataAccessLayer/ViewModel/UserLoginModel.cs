using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.ViewModel
{
    public class UserLoginModel
    {
        [Required(ErrorMessage = "E-Posta Adresi alanı boş geçilemez!")]
        [DisplayName("E-Posta Adresi")]
        [EmailAddress(ErrorMessage = "Geçersiz E-Posta Adresi")]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Şifre alanı boş geçilemez!")]
        [DisplayName("Şifre")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Şifre alanı en az 5 karakterli olmak zorundadır")]
        public string Password { get; set; }
    }
}
