using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable("Product");
            HasKey(a => a.ProductId);

            Property(a => a.ProductName)
                .HasMaxLength(50)
                .IsOptional();

            Property(a => a.SeoUrl)
                .HasMaxLength(250)
                .IsOptional();

            Property(a => a.ProductPrice)
                .HasColumnType("Money")
                .IsOptional();

            Property(a => a.ReferralPrice)
                .HasColumnType("Money")
               .IsOptional();

            Property(a => a.Rsp)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.ProductShortDescription)
               .IsOptional();

            Property(a => a.CreatedDate)
               .IsOptional();

            Property(a => a.BrandId)
               .IsOptional();

            Property(a => a.ProductCategory)
              .IsOptional();

            Property(a => a.ProductDescription)
              .IsOptional();

            Property(a => a.ActivePassive)
              .IsOptional();

            Property(a => a.ProductHit)
              .IsOptional();

            Property(a => a.Sku)
              .HasMaxLength(50)
              .IsOptional();

            Property(a => a.Stock)
              .IsOptional();

            Property(a => a.WatCode)
             .IsOptional();

            Property(a => a.ProductCriterion)
             .IsOptional();

            Property(a => a.EndDate)
              .IsOptional();

            Property(a => a.SpeacilPrice)
                .HasColumnType("Money")
              .IsOptional();

            Property(a => a.MustStockLine)
              .IsOptional();

            Property(a => a.Por)
              .HasMaxLength(50)
              .IsOptional();

            Property(a => a.BarcodeCode)
              .HasMaxLength(50)
              .IsOptional();

            Property(a => a.UpdateDate)
              .IsOptional();

            Property(a => a.CargoPrice)
             .IsOptional();

            Property(a => a.N11)
             .IsOptional();

        }
    }
}
