using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class TownMap : EntityTypeConfiguration<Town>
    {
        public TownMap()
        {
            ToTable("Town");
            HasKey(a => a.TownId);

            Property(a => a.DistrictIdNumber)
                .IsOptional();

            Property(a => a.BucakIdNumber)
                .IsOptional();

            Property(a => a.TownIdNumber)
               .IsOptional();

            Property(a => a.IdNumber)
               .IsOptional();

            Property(a => a.TownName)
               .IsOptional();
        }
    }
}
