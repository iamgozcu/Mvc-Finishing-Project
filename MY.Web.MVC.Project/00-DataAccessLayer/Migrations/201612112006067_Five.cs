namespace _00_DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Five : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Setting", "Facebook", c => c.String(maxLength: 250));
            AddColumn("dbo.Setting", "Twitter", c => c.String(maxLength: 250));
            AddColumn("dbo.Setting", "Instagram", c => c.String(maxLength: 250));
            AddColumn("dbo.Setting", "Linkedin", c => c.String(maxLength: 250));
            AddColumn("dbo.Setting", "Google", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Setting", "Google");
            DropColumn("dbo.Setting", "Linkedin");
            DropColumn("dbo.Setting", "Instagram");
            DropColumn("dbo.Setting", "Twitter");
            DropColumn("dbo.Setting", "Facebook");
        }
    }
}
