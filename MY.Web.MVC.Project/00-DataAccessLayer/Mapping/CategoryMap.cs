using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable("Category");
            HasKey(a => a.CategoryId);

            Property(a => a.CategoryName)
                .HasMaxLength(50)
                .IsOptional();

            Property(a => a.SubCategoryId)
               .IsOptional();

            Property(a => a.CategoryImage)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.CategoryBanner)
             .IsOptional();

            Property(a => a.ActivePassive)
              .IsOptional();

            Property(a => a.ProductGridSeoUrl)
                .HasMaxLength(50)
                .IsOptional();
        }
    }
}
