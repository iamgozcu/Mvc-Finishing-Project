using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class VirtualPosBankMap : EntityTypeConfiguration<VirtualPosBank>
    {
        public VirtualPosBankMap()
        {
            ToTable("VirtualPosBank");
            HasKey(a => a.BankId);

            Property(a => a.BankCode)
                .HasMaxLength(50)
                .IsOptional();

            Property(a => a.BankName)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.Bank3DLink)
               .IsOptional();

            Property(a => a.BankMemberId)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.BankAnswer)
               .IsOptional();


            Property(a => a.Bank3DSecurity)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.BankImage)
               .HasMaxLength(50)
               .IsOptional();


            Property(a => a.AktivePassive)
               .IsOptional();

            Property(a => a.BankSort)
               .IsOptional();
            
        }
    }
}
