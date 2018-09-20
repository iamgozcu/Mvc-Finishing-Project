using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class CustomerDetailMap : EntityTypeConfiguration<CustomerDetail>
    {
        public CustomerDetailMap()
        {
            ToTable("CustomerDetail");
            HasKey(a => a.CustomerDetailId);

            Property(a => a.CustomerDetailName)
                .HasMaxLength(50)
                .IsOptional();

            Property(a => a.CustomerDetailSurname)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.EmailAdress)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.AddressName)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.CompanyName)
               .HasMaxLength(250)
               .IsOptional();

            Property(a => a.TaxAdministration)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.TaxNumber)
                .HasColumnType("char")
                .HasMaxLength(11)
               .IsOptional();

            Property(a => a.Phone)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.GSM)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.Address)
              .IsOptional();

            Property(a => a.CityId)
               .IsOptional();

            Property(a => a.DistrictId)
               .IsOptional();

            Property(a => a.CustomerId)
              .IsOptional();
        }
    }
}
