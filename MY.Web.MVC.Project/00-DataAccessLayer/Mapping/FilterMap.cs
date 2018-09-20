using _00_DataAccessLayer.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class FilterMap : EntityTypeConfiguration<Filter>
    {
        public FilterMap()
        {
            ToTable("Filter");
            HasKey(a => a.FilterId);

            Property(a => a.FilterTitle)
                .HasMaxLength(50)
                .IsOptional();

            Property(a => a.CategoryId)
               .IsOptional();
        }
    }
}
