using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class ContentPageMap : EntityTypeConfiguration<ContentPage>
    {
        public ContentPageMap()
        {
            ToTable("ContentPage");
            HasKey(a => a.PageId);

            Property(a => a.PageName)
                .HasMaxLength(50)
                .IsOptional();

            Property(a => a.PageContent)
               .IsOptional();

            Property(a => a.PageImage)
               .HasMaxLength(50)
               .IsOptional();


        }
    }
}
