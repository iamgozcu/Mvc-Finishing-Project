using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class BankMap : EntityTypeConfiguration<Bank>
    {
        public BankMap()
        {
            ToTable("Bank");
            HasKey(b => b.BankId);

            Property(b => b.BankName)
                .HasMaxLength(50)
                .IsOptional();

            Property(b => b.BankImage)
               .HasMaxLength(50)
               .IsOptional();

            Property(b => b.AccountNumber)
               .HasMaxLength(50)
               .IsOptional();

            Property(b => b.AccountOwner)
               .HasMaxLength(50)
               .IsOptional();

            Property(b => b.BranchName)
               .HasMaxLength(50)
               .IsOptional();

            Property(b => b.BranchCode)
               .HasMaxLength(50)
               .IsOptional();

            Property(b => b.AccountType)
               .HasMaxLength(50)
               .IsOptional();

            Property(b => b.IbanNo)
               .HasMaxLength(50)
               .IsOptional();
        }
    }
}
