using _00_DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_DataAccessLayer.ViewModel
{
    public class ProductModel
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Ürün Adı alanı boş geçilemez!")]
        [DisplayName("Ürün Adı")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Seo Linki alanı boş geçilemez!")]
        [DisplayName("Seo Linki")]
        [Index(IsUnique =true)]
        public string SeoUrl { get; set; }

        [Required(ErrorMessage = "Fiyatı alanı boş geçilemez!")]
        [DisplayName("Fiyatı")]
        public decimal ProductPrice { get; set; }

        public decimal ReferralPrice { get; set; }
        [DisplayName("Piyasa Fiyatı")]
        public string Rsp { get; set; }

        [Required(ErrorMessage = "Ürün Kısa Açıklaması alanı boş geçilemez!")]
        [DisplayName("Ürün Kısa Açıklaması")]
        public string ProductShortDescription { get; set; }

        [Required(ErrorMessage = "Kayıt Tarihi alanı boş geçilemez!")]
        [DisplayName("Kayıt Tarihi")]
        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "Marka alanı boş geçilemez!")]
        [DisplayName("Marka")]
        public int BrandId { get; set; }
        [Required(ErrorMessage = "Ürün Açıklaması alanı boş geçilemez!")]
        [DisplayName("Ürün Açıklaması")]
        public string ProductDescription { get; set; }
        [DisplayName("Aktif Pasif")]
        public bool ActivePassive { get; set; }
        [Required(ErrorMessage = "Ürün Hit alanı boş geçilemez!")]
        [DisplayName("Ürün Hit")]
        public int ProductHit { get; set; }
        [DisplayName("Alış Fiyatı")]
        public string Sku { get; set; }
        [Required(ErrorMessage = "Stok Miktarı alanı boş geçilemez!")]
        [DisplayName("Stok Miktarı")]
        public int Stock { get; set; }
        [DisplayName("KDV")]
        public int WatCode { get; set; }
        [Required(ErrorMessage = "Kriter alanı boş geçilemez!")]
        [DisplayName("Kriter")]
        public int ProductCriterion { get; set; }
        [Required(ErrorMessage = "Bitiş Tarihi alanı boş geçilemez!")]
        [DisplayName("Bitiş Tarihi")]
        public DateTime EndDate { get; set; }
        [DisplayName("Özel Fiyat")]
        public decimal SpeacilPrice { get; set; }
        public bool MustStockLine { get; set; }
        public string Por { get; set; }
        [DisplayName("Barkod Kodu")]
        public string BarcodeCode { get; set; }
        [DisplayName("Güncelleme Tarihi")]
        public DateTime UpdateDate { get; set; }
        [DisplayName("Kargo Fiyatı")]
        public int CargoPrice { get; set; }
        [DisplayName("N11'e Gitsin Mi?")]
        public bool N11 { get; set; }
    }
}
