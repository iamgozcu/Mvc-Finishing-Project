using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class CargoMap : EntityTypeConfiguration<Cargo>
    {
        public CargoMap()
        {
            ToTable("Cargo");
            HasKey(c => c.CargoId);

            Property(c => c.CargoName)
                .HasMaxLength(50)
                .IsOptional();

            Property(c => c.CreatedDate)
                .IsOptional();

            Property(c => c.CargoImage)
               .HasMaxLength(50)
                .IsOptional();
        }
    }
}
