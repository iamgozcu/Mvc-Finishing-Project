using _00_DataAccessLayer.Entity;
using System.Data.Entity.ModelConfiguration;

namespace _00_DataAccessLayer.Mapping
{
    public class AdministratorMap : EntityTypeConfiguration<Administrator>//kütüphane ekleyip
        //bunu yukarıda entity içindeki administrator varlık tablosu yani  tablonun alanlarını
        //çeker.
    {
        public AdministratorMap()
        /*Fluent Api kullanılarak veri tabanı sınıflarını 
        ve ilişkilerini yapılandırabilmenin bir yoludur.*/

        {
            ToTable("Administrator");
            HasKey(a => a.AdminId);//veritanbanında primery key olarak tanımlanan alan

            Property(a => a.Name)//property tablo için özellik atamak için kullanılır
                .HasMaxLength(50)//alanın maksimum karakter uzunluğunu belirler
                .IsOptional();//alanların zorunlu olduğunu gösterir

            Property(a => a.Surname)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.UserName)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.Password)
               .HasMaxLength(50);

            Property(a => a.EmailAdress)
               .HasMaxLength(50)
               .IsOptional();

            Property(a => a.IsActive)
               .IsOptional();

            Property(a => a.Role)
               .IsOptional();

            Property(a => a.Path)
               .HasMaxLength(50)
               .IsOptional();
        }
    }
}