using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class FilterDetailMap : EntityTypeConfiguration<FilterDetail>
    {
        public FilterDetailMap()
        {
            ToTable("FilterDetail");
            HasKey(a => a.FilterDetailId);

            Property(a => a.FilterDetailTitle)
                .HasMaxLength(50)
                .IsOptional();

            Property(a => a.FilterId)
               .IsOptional();
        }
    }
}
