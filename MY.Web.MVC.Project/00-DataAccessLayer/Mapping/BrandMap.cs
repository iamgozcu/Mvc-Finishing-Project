using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class BrandMap : EntityTypeConfiguration<Brand>
    {
        public BrandMap()
        {
            ToTable("Brand");
            HasKey(b => b.BrandId);

            Property(p => p.BrandName)
               .HasMaxLength(50)
               .IsOptional();

            Property(p => p.BrandImage)
                .HasMaxLength(250)
                .IsOptional();

            Property(p => p.Sorting)
              .IsOptional();

            Property(p => p.ActivePassive)
                .IsOptional();
        }
    }
}
