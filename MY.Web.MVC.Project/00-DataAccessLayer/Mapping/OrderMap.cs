using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            ToTable("Order");
            HasKey(a => a.OrderId);

            Property(a => a.OrderDate)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.OrderDeliveryDate)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.OrderStatu)
               .IsOptional();

            Property(a => a.OrderPaymentOptionDepositCard)
               .IsOptional();

            Property(a => a.OrderPaymentCard)
               .IsOptional();

            Property(a => a.OrderPaymentCardResult)
               .IsOptional();

            Property(a => a.OrderPaymentStructuredIp)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.OrderPaymentCardPin)
               .IsOptional();

            Property(a => a.OrderPaymentInstallmentNumber)
               .IsOptional();

            Property(a => a.OrderTotalVAT)
              .HasMaxLength(50)
              .IsOptional();


            Property(a => a.PriceExcludingOrderVAT)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.PriceIncludingOrderTotalVAT)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.OrderTotalCargoPrice)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.TotalOrder)
               .IsOptional();

            Property(a => a.OrderMemberId)
               .IsOptional();

            Property(a => a.OrderMemberName)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.OrderMemberSurname)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.OrderMemberEmail)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.OrderMemberCompany)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.OrderMemberTaxOffice)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.OrderMemberTaxNumber)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.OrderMemberGsm)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.OrderMemberPhone)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.OrderMemberCity)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.OrderMemberDistrict)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.OrderMemberAddress)
             .HasMaxLength(250)
             .IsOptional();

            Property(a => a.OrderNote)
               .HasMaxLength(250)
               .IsOptional();

            Property(a => a.OrderInvoiceName)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.OrderInvoiceSurname)
             .HasMaxLength(50)
             .IsOptional();

            Property(a => a.OrderInvoiceEmail)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.OrderInvoiceCompany)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.OrderInvoiceTaxAdministration)
             .HasMaxLength(50)
             .IsOptional();

            Property(a => a.OrderInvoiceTaxNumber)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.OrderInvoiceGsm)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.OrderInvoicePhone)
             .HasMaxLength(50)
             .IsOptional();

            Property(a => a.OrderInvoiceCity)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.OrderInvoiceDistrict)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.OrderInvoiceAddress)
             .HasMaxLength(250)
             .IsOptional();

            Property(a => a.OrderInvoiceTrackingNumber)
               .HasMaxLength(50)
               .IsOptional();

        }
    }
}
