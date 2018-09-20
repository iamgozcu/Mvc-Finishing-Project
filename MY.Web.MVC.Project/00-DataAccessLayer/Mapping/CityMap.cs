using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class CityMap : EntityTypeConfiguration<City>
    {
        public CityMap()
        {
            ToTable("City");
            HasKey(a => a.CityId);

            Property(a => a.ProvincialIdentificationNo)
                .IsOptional();

            Property(a => a.CityName)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.CountryId)
               .IsOptional();
        }
    }
}
