namespace _00_DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Twelve : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Category", "ProductGridSeoUrl", c => c.String(maxLength: 50));
            DropColumn("dbo.Category", "SeoUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Category", "SeoUrl", c => c.String(maxLength: 50));
            DropColumn("dbo.Category", "ProductGridSeoUrl");
        }
    }
}
