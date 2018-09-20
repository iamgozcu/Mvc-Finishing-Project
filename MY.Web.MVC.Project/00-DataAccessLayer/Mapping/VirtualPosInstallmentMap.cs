using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class VirtualPosInstallmentMap : EntityTypeConfiguration<VirtualPosInstallment>
    {
        public VirtualPosInstallmentMap()
        {
            ToTable("VirtualPosInstallment");
            HasKey(a => a.InstallmentId);

            Property(a => a.BankId)
                .IsOptional();

            Property(a => a.NumberOfInstallment)
               .IsOptional();

            Property(a => a.InstallmentRate)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.ActivePassive)
               .IsOptional();
        }
    }
}
