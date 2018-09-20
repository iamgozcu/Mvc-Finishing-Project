using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class ShowcaseMap : EntityTypeConfiguration<Showcase>
    {
        public ShowcaseMap()
        {
            ToTable("Showcase");
            HasKey(a => a.ShowcaseId);

            Property(a => a.ShowcaseName)
                .HasMaxLength(50)
                .IsOptional();

            Property(a => a.ShowcaseSortNumber)
               .IsOptional();
        }
    }
}
