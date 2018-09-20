using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class ProductImageMap : EntityTypeConfiguration<ProductImage>
    {
        public ProductImageMap()
        {
            ToTable("ProductImage");
            HasKey(a => a.ImageId);

            Property(a => a.Path)
                .HasMaxLength(250)
                .IsOptional();

            Property(a => a.ProductId)
               .IsOptional();

            Property(a => a.CreatedDate)
             .IsOptional();
        }
    }
}
