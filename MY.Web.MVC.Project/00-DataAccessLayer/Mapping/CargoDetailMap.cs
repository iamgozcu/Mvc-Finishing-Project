using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class CargoDetailMap: EntityTypeConfiguration<CargoDetail>
    {
        public CargoDetailMap()
        {
            ToTable("CargoDetail");
            HasKey(cd => cd.CargoDesiId);

            Property(cd => cd.CargoParentId)
               .IsOptional();

            Property(cd => cd.CargoDesiValue)
               .IsOptional();

            Property(cd => cd.CargoDesiPrice)
                .HasMaxLength(50)
                .IsOptional();

            Property(cd => cd.CargoDesiCityId)
               .IsOptional();
        }
    }
}
