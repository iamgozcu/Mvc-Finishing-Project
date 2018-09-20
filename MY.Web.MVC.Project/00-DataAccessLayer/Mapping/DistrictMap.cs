using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class DistrictMap : EntityTypeConfiguration<District>
    {
        public DistrictMap()
        {
            ToTable("District");
            HasKey(a => a.DistrictId);

            Property(a => a.IndentityNumber)
                .IsOptional();

            Property(a => a.DistrictName)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.ProvincialIdentificationNo)
               .IsOptional();
        }
    }
}
