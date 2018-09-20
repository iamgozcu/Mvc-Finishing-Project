using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class StatisticMap : EntityTypeConfiguration<Statistic>
    {
        public StatisticMap()
        {
            ToTable("Statistic");
            HasKey(a => a.StatisticId);
 
            Property(a => a.IP)
                .HasMaxLength(50)
                .IsOptional();

            Property(a => a.Date)
               .IsOptional();

            Property(a => a.Page)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.Language)
               .HasMaxLength(50)
               .IsOptional();
        }
    }
}
