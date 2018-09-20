namespace _00_DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationSix : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductCategory",
                c => new
                    {
                        ProductCategoryId = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(),
                        ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductCategoryId);
            
            DropTable("dbo.Company");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        CompanySeo = c.String(maxLength: 50),
                        CompanyName = c.String(maxLength: 50),
                        CompanyTitle = c.String(maxLength: 50),
                        CompanyPassword = c.String(maxLength: 50),
                        CompanyImage = c.String(maxLength: 50),
                        CompanyDescription = c.String(),
                        CompanyFacebook = c.String(maxLength: 50),
                        CompanyTwitter = c.String(maxLength: 50),
                        CompanyGoogle = c.String(maxLength: 50),
                        CompanyCountry = c.String(maxLength: 50),
                        CompanyCity = c.String(maxLength: 50),
                        CompanyCounty = c.String(maxLength: 50),
                        CompanyDistrict = c.String(maxLength: 50),
                        CompanyStreet = c.String(maxLength: 50),
                        CompanyAddress = c.String(),
                        CompanyNumber = c.String(maxLength: 50),
                        CompanyPhone = c.String(maxLength: 50),
                        CompanyGsm = c.String(maxLength: 50),
                        CompanyEmail = c.String(maxLength: 50),
                        CompanyWeb = c.String(maxLength: 50),
                        CompanyMap = c.String(),
                        CompanyPaid = c.Boolean(),
                        CompanyRegistration = c.String(maxLength: 50),
                        CompanySector = c.Int(),
                        ActivePassive = c.Boolean(),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            DropTable("dbo.ProductCategory");
        }
    }
}
