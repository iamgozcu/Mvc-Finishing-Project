using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class FilterProductMap : EntityTypeConfiguration<FilterProduct>
    {
        public FilterProductMap()
        {
            ToTable("FilterProduct");
            HasKey(a => a.FilterProductId);

            Property(a => a.FilterDetailId)
                .IsOptional();

            Property(a => a.ProductId)
               .IsOptional();
        }
    }
}
