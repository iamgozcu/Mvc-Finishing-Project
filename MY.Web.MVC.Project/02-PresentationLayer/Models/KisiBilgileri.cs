using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_PresentationLayer.Models
{
    public class KisiBilgileri
    {
        public KisiBilgileri()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public int UyeID { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string Eposta { get; set; }
        public string Firma { get; set; }
        public string Vergi_Dairesi { get; set; }
        public string Vergi_No { get; set; }
        public string GSM { get; set; }
        public string Telefon { get; set; }
        public string sehir { get; set; }
        public string ilce { get; set; }
        public string adres { get; set; }
        public string not { get; set; }

        public string fatura_Ad { get; set; }
        public string fatura_Soyad { get; set; }
        public string fatura_E_posta { get; set; }
        public string fatura_Firma { get; set; }
        public string fatura_Vergi_Dairesi { get; set; }
        public string fatura_Vergi_No { get; set; }
        public string fatura_GSM { get; set; }
        public string fatura_Telefon { get; set; }
        public string fatura_Sehir { get; set; }
        public string fatura_Ilce { get; set; }
        public string fatura_Adres { get; set; }
    }
}
