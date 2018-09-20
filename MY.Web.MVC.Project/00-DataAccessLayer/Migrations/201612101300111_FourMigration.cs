namespace _00_DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FourMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Product", "N11", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Product", "N11", c => c.Int());
        }
    }
}
