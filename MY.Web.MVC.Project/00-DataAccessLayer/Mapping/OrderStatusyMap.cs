using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class OrderStatusyMap : EntityTypeConfiguration<OrderStatusy>
    {
        public OrderStatusyMap()
        {
            ToTable("OrderStatusy");//tablo adını yapılandırır
            HasKey(a => a.OrderStatuId);

            Property(a => a.OrderStatu)
                .HasMaxLength(50)
                .IsOptional();

            Property(a => a.OrderStatuColor)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.ActivePassive)
               .IsOptional();

        }
    }
}
