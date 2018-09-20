using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class SliderMap : EntityTypeConfiguration<Slider>
    {
        public SliderMap()
        {
            ToTable("Slider");
            HasKey(a => a.SliderId);

            Property(a => a.SliderImage)
                .HasMaxLength(50)
                .IsOptional();

            Property(a => a.SliderUrl)
               .HasMaxLength(50)
               .IsOptional();

        }
    }
}
