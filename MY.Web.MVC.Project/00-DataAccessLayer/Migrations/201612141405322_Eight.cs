namespace _00_DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Eight : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "SeoUrl", c => c.String(maxLength: 250));
            DropTable("dbo.Busine");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Busine",
                c => new
                    {
                        BusinessId = c.Int(nullable: false, identity: true),
                        BusinessName = c.String(),
                        BusinessAdres1 = c.String(),
                        BusinessAdres2 = c.String(),
                        BusinessAdres3 = c.String(),
                        BusinessPostCode = c.String(maxLength: 50),
                        BusinessTelNo = c.String(maxLength: 50),
                        MobileNo = c.String(maxLength: 50),
                        EmailAdres = c.String(maxLength: 50),
                        Passwords = c.String(maxLength: 50),
                        CompanyNumber = c.String(maxLength: 50),
                        VatNumber = c.String(maxLength: 50),
                        PrimaryContact = c.String(maxLength: 50),
                        SecondaryContact = c.String(maxLength: 50),
                        BusinesType = c.String(maxLength: 50),
                        Other = c.String(maxLength: 50),
                        Tobacconist = c.String(maxLength: 50),
                        AreYou18 = c.String(maxLength: 50),
                        Depot = c.String(maxLength: 50),
                        BankName = c.String(maxLength: 50),
                        BankAdres1 = c.String(),
                        BankAdres2 = c.String(),
                        BankAdres3 = c.String(),
                        BankPostCode = c.String(maxLength: 50),
                        AccountName = c.String(maxLength: 50),
                        AccountNumber = c.String(maxLength: 50),
                        SortCode = c.String(maxLength: 50),
                        Requirements = c.String(maxLength: 50),
                        ActivePassive = c.Boolean(),
                        Token = c.String(maxLength: 50),
                        Balance = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.BusinessId);
            
            DropColumn("dbo.Product", "SeoUrl");
        }
    }
}
