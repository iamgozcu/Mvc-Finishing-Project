using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_DataAccessLayer.ViewModel
{
    public class SendMailModel
    {
        [Required(ErrorMessage = "Ad Soyad alanı boş geçilemez!")]
        [DisplayName("Ad Soyad")]
        public string NameSurname { get; set; }
        [Required(ErrorMessage = "E-Posta Adresi alanı boş geçilemez!")]
        [DisplayName("E-Posta Adresi")]
        [EmailAddress(ErrorMessage = "Geçersiz E-Posta Adresi")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Mesaj alanı boş geçilemez!")]
        [DisplayName("Mesaj")]
        public string Message { get; set; }
    }
}
