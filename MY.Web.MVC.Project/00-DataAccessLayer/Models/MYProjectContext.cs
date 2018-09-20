using _00_DataAccessLayer.Migrations;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;

namespace _00_DataAccessLayer.Models
{
    public class MYProjectContext : DbContext//SOR??????
        //Kullanılan oluşturma kodu hangisi
    {
        public MYProjectContext() : base("name=MYProjectDBEntities")
        {
           Database.SetInitializer(new MigrateDatabaseToLatestVersion<MYProjectContext, Configuration>());
        }
        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
            .Where(type => !string.IsNullOrEmpty(type.Namespace))
            .Where(type => type.BaseType != null && type.BaseType.IsGenericType &&
                type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }
            base.OnModelCreating(modelBuilder);
        }
        
    }
}