namespace _00_DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TwoMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Administrator", "Name", c => c.String(maxLength: 50));
            AlterColumn("dbo.Administrator", "UserName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Administrator", "Password", c => c.String(maxLength: 50));
            AlterColumn("dbo.Administrator", "EmailAdress", c => c.String(maxLength: 50));
            AlterColumn("dbo.Administrator", "Path", c => c.String(maxLength: 50));
            AlterColumn("dbo.Bank", "BankName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Bank", "BankImage", c => c.String(maxLength: 50));
            AlterColumn("dbo.Bank", "AccountNumber", c => c.String(maxLength: 50));
            AlterColumn("dbo.Bank", "AccountOwner", c => c.String(maxLength: 50));
            AlterColumn("dbo.Bank", "BranchCode", c => c.String(maxLength: 50));
            AlterColumn("dbo.Bank", "IbanNo", c => c.String(maxLength: 50));
            AlterColumn("dbo.Banner", "BannerImage", c => c.String());
            AlterColumn("dbo.Customer", "CustomerName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Customer", "CustomerSurname", c => c.String(maxLength: 50));
            AlterColumn("dbo.Customer", "EmailAddress", c => c.String(maxLength: 50));
            AlterColumn("dbo.Customer", "Password", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customer", "Password", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customer", "EmailAddress", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customer", "CustomerSurname", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customer", "CustomerName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Banner", "BannerImage", c => c.String(nullable: false));
            AlterColumn("dbo.Bank", "IbanNo", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Bank", "BranchCode", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Bank", "AccountOwner", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Bank", "AccountNumber", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Bank", "BankImage", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Bank", "BankName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Administrator", "Path", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Administrator", "EmailAdress", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Administrator", "Password", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Administrator", "UserName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Administrator", "Name", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
