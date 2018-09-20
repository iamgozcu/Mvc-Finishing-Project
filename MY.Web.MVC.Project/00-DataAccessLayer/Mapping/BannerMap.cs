using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class BannerMap : EntityTypeConfiguration<Banner>
    {
        public BannerMap()
        {
            ToTable("Banner");
            HasKey(b => b.BannerId);

            Property(p => p.BannerImage)
                .IsOptional();

            Property(p => p.BannerUrl)
                .IsOptional();
        }
    }
}
