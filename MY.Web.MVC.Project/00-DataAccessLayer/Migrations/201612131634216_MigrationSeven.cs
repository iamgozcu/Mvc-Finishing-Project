namespace _00_DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationSeven : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.ShowcaseCompany");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ShowcaseCompany",
                c => new
                    {
                        ShowcaseId = c.Int(nullable: false, identity: true),
                        CompanyId = c.Int(),
                        ShowcaseNumber = c.Int(),
                    })
                .PrimaryKey(t => t.ShowcaseId);
            
        }
    }
}
