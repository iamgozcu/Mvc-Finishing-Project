using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class SettingMap : EntityTypeConfiguration<Setting>
    {
        public SettingMap()
        {
            ToTable("Setting");
            HasKey(a => a.SettingId);

            Property(a => a.BasketLimitKeeps)
                .HasMaxLength(50)
                .IsOptional();

            Property(a => a.OrderEmailAddress)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.ContactMailAddress)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.Address)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.PostCode)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.CompanyName)
              .HasMaxLength(50)
              .IsOptional();

            Property(a => a.GSM)
            .HasMaxLength(50)
            .IsOptional();

            Property(a => a.Phone)
              .HasMaxLength(50)
              .IsOptional();

            Property(a => a.Phone2)
              .HasMaxLength(50)
              .IsOptional();

            Property(a => a.Fax)
            .HasMaxLength(50)
            .IsOptional();

            Property(a => a.Map)
              .IsOptional();

            Property(a => a.CompanyNumber)
              .HasMaxLength(50)
              .IsOptional();

            Property(a => a.Slogan)
              .HasMaxLength(250)
              .IsOptional();

            Property(a => a.Facebook)
            .HasMaxLength(250)
            .IsOptional();

            Property(a => a.Twitter)
            .HasMaxLength(250)
            .IsOptional();

            Property(a => a.Instagram)
            .HasMaxLength(250)
            .IsOptional();

            Property(a => a.Linkedin)
            .HasMaxLength(250)
            .IsOptional();

            Property(a => a.Google)
            .HasMaxLength(250)
            .IsOptional();
        }
    }
}
