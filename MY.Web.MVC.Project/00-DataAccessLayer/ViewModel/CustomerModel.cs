using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _00_DataAccessLayer.ViewModel
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Adı alanı boş geçilemez!")]
        [DisplayName("Adı")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Ad alanı 2-20 karakter arasında girebilirsiniz.")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Soyadı alanı boş geçilemez!")]
        [DisplayName("Soyadı")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Soyad alanı 2-20 karakter arasında girebilirsiniz.")]
        public string CustomerSurname { get; set; }
        [Required(ErrorMessage = "E-Posta Adresi alanı boş geçilemez!")]
        [DisplayName("E-Posta Adresi")]
        [EmailAddress(ErrorMessage = "Geçersiz E-Posta Adresi")]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "Şifre alanı boş geçilemez!")]
        [DisplayName("Şifre")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Şifre alanı en az 5 karakterli olmak zorundadır")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre Tekrar alanı boş geçilemez!")]
        [DisplayName("Şifre Tekrar")]
        [Compare("Password", ErrorMessage = "Şifreler Eşleşmiyor !")]
        public string ConfirmPassword { get; set; }
        public DateTime MembershipDate { get; set; }
        public bool ActivePassive { get; set; }

      
    }
}
