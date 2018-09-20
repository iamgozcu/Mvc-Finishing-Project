using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class SectorMap : EntityTypeConfiguration<Sector>
    {
        public SectorMap()
        {
            ToTable("Sector");
            HasKey(a => a.SectorId);

            Property(a => a.SectorName)
                .HasMaxLength(250)
                .IsOptional();

        }
    }
}
