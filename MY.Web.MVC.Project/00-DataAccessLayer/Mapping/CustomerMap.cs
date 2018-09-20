using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            ToTable("Customer");
            HasKey(a => a.CustomerId);

            Property(a => a.CustomerName)
                .HasMaxLength(50)
                .IsOptional();

            Property(a => a.CustomerSurname)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.EmailAddress)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.Password)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.MembershipDate)
                .IsOptional();

            Property(a => a.ActivePassive)
                .IsOptional();

        }
    }
}
