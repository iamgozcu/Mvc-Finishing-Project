using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class ProductCategoryMap : EntityTypeConfiguration<ProductCategory>
    {
        public ProductCategoryMap()
        {
            ToTable("ProductCategory");
            HasKey(a => a.ProductCategoryId);

            Property(a => a.CategoryId)
                .IsOptional();

            Property(a => a.ProductId)
               .IsOptional();
        }
    }
}
