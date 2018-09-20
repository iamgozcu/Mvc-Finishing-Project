using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class ShowcaseProductMap : EntityTypeConfiguration<ShowcaseProduct>
    {
        public ShowcaseProductMap()
        {
            ToTable("ShowcaseProduct");
            HasKey(a => a.ShowcaseProductId);

            Property(a => a.ProductId)
                .IsOptional();

            Property(a => a.ShowcaseProductSort)
               .IsOptional();

            Property(a => a.ShowcaseProductTopId)
               .IsOptional();
           
        }
    }
}
