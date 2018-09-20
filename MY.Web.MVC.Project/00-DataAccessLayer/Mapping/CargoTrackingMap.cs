using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class CargoTrackingMap : EntityTypeConfiguration<CargoTracking>
    {
        public CargoTrackingMap()
        {
            ToTable("CargoTracking");
            HasKey(ct => ct.CargoTrackingId);

            Property(ct => ct.CargoTrackingNumber)
                .HasMaxLength(50)
                .IsOptional();

            Property(ct => ct.CargoTrackingLink)
                .IsOptional();

            Property(ct => ct.OrderId)
               .IsOptional();

            Property(ct => ct.OrderDetailId)
               .IsOptional();

        }
    }
}
