using System;

namespace _00_DataAccessLayer.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string SeoUrl { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ReferralPrice { get; set; }
        public string Rsp { get; set; }
        public string ProductShortDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public int BrandId { get; set; }
        public int ProductCategory { get; set; }
        public string ProductDescription { get; set; }
        public bool ActivePassive { get; set; }
        public int ProductHit { get; set; }
        public string Sku { get; set; }
        public int Stock { get; set; }
        public int WatCode { get; set; }
        public int ProductCriterion { get; set; }
        public DateTime EndDate { get; set; }
        public decimal SpeacilPrice { get; set; }
        public bool MustStockLine { get; set; }
        public string Por { get; set; }
        public string BarcodeCode { get; set; }
        public DateTime UpdateDate { get; set; }
        public int CargoPrice { get; set; }
        public bool N11 { get; set; }
    }
}
