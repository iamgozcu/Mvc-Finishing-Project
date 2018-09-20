using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_DataAccessLayer.ViewModel
{
    public class SettingModel
    {
        [DisplayName("Ayarlar No")]
        public int SettingId { get; set; }
        [DisplayName("Sepet Limit Tutar")]
        public string BasketLimitKeeps { get; set; }
        [Required(ErrorMessage = "Sipariş E-Posta Adresi alanı boş geçilemez!")]
        [DisplayName("Sipariş E-Posta Adresi")]
        public string OrderEmailAddress { get; set; }
        [Required(ErrorMessage = "İletişim E-Posta Adresi alanı boş geçilemez!")]
        [DisplayName("İletişim E-Posta Adresi")]
        public string ContactMailAddress { get; set; }
        [Required(ErrorMessage = "Adres alanı boş geçilemez!")]
        [DisplayName("Adres")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Posta Kodu alanı boş geçilemez!")]
        [DisplayName("Posta Kodu")]
        public string PostCode { get; set; }
        [Required(ErrorMessage = "Şirket Adı alanı boş geçilemez!")]
        [DisplayName("Şirket Adı")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Cep Tel alanı boş geçilemez!")]
        [DisplayName("Cep Tel")]
        public string GSM { get; set; }
        [Required(ErrorMessage = "Telefon alanı boş geçilemez!")]
        [DisplayName("Telefon")]
        public string Phone { get; set; }
        [DisplayName("Telefon 2")]
        public string Phone2 { get; set; }
        [DisplayName("Fax")]
        public string Fax { get; set; }
        [Required(ErrorMessage = "Harita alanı boş geçilemez!")]
        [DisplayName("Harita")]
        public string Map { get; set; }
        [DisplayName("Şirket Numarası")]
        public string CompanyNumber { get; set; }
        [DisplayName("Slogan")]
        public string Slogan { get; set; }
        [Required(ErrorMessage = "Facebook alanı boş geçilemez!")]
        [DisplayName("Facebook")]
        public string Facebook { get; set; }
        [Required(ErrorMessage = "Twitter alanı boş geçilemez!")]
        [DisplayName("Twitter")]
        public string Twitter { get; set; }
        [Required(ErrorMessage = "Instagram alanı boş geçilemez!")]
        [DisplayName("Instagram")]
        public string Instagram { get; set; }
        [Required(ErrorMessage = "Linkedin alanı boş geçilemez!")]
        [DisplayName("Linkedin")]
        public string Linkedin { get; set; }
        [Required(ErrorMessage = "Google alanı boş geçilemez!")]
        [DisplayName("Google")]
        public string Google { get; set; }
    }
}
