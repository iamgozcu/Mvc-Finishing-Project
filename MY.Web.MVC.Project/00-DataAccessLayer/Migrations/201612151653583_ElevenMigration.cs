namespace _00_DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ElevenMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Category", "SeoUrl", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Category", "SeoUrl");
        }
    }
}
