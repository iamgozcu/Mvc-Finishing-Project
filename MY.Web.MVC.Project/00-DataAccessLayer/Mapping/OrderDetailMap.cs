using _00_DataAccessLayer.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class OrderDetailMap : EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailMap()
        {
            ToTable("OrderDetail");
            HasKey(a => a.OrderDetailId);

            Property(a => a.OrderTopId)
                .IsOptional();

            Property(a => a.OrderDetailProductId)
               .IsOptional();

            Property(a => a.OrderDetailProductImage)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.OrderDetailProductName)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.OrderDetailProductPrice)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.OrderDetailProductPiece)
               .IsOptional();

            Property(a => a.OrderDetailProductKdv)
              .HasMaxLength(50)
              .IsOptional();

            Property(a => a.OrderDetailProductStatus)
              .IsOptional();

            Property(a => a.OrderDetailProductDiscount)
              .IsOptional();

        }
    }
}
