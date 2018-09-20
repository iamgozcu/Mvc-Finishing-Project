using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class ProductFilterMap : EntityTypeConfiguration<ProductFilter>
    {
        public ProductFilterMap()
        {
            ToTable("ProductFilter");
            HasKey(a => a.ProductFilterId);

            Property(a => a.ProductId)
                .IsOptional();

            Property(a => a.FilterId)
               .IsOptional();
        }
    }
}
