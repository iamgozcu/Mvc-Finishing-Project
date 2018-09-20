using _00_DataAccessLayer.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class CountryMap : EntityTypeConfiguration<Country>
    {
        public CountryMap()
        {
            ToTable("Country");
            HasKey(a => a.CountryId);

            Property(a => a.CountryName)
                .HasMaxLength(50)
                .IsOptional();

        }
    }
}
