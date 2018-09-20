namespace _00_DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OneMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administrator",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        UserName = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        EmailAdress = c.String(nullable: false, maxLength: 50),
                        IsActive = c.Boolean(nullable: false),
                        Role = c.Int(nullable: false),
                        Path = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.Bank",
                c => new
                    {
                        BankId = c.Int(nullable: false, identity: true),
                        BankName = c.String(nullable: false, maxLength: 50),
                        BankImage = c.String(nullable: false, maxLength: 50),
                        AccountNumber = c.String(nullable: false, maxLength: 50),
                        AccountOwner = c.String(nullable: false, maxLength: 50),
                        BranchName = c.String(nullable: false, maxLength: 50),
                        BranchCode = c.String(nullable: false, maxLength: 50),
                        AccountType = c.String(nullable: false, maxLength: 50),
                        IbanNo = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.BankId);
            
            CreateTable(
                "dbo.Banner",
                c => new
                    {
                        BannerId = c.Int(nullable: false, identity: true),
                        BannerImage = c.String(nullable: false),
                        BannerUrl = c.String(),
                    })
                .PrimaryKey(t => t.BannerId);
            
            CreateTable(
                "dbo.Brand",
                c => new
                    {
                        BrandId = c.Int(nullable: false, identity: true),
                        BrandName = c.String(nullable: false, maxLength: 50),
                        BrandImage = c.String(nullable: false, maxLength: 250),
                        ActivePassive = c.Boolean(nullable: false),
                        Sorting = c.Int(),
                    })
                .PrimaryKey(t => t.BrandId);
            
            CreateTable(
                "dbo.Busine",
                c => new
                    {
                        BusinessId = c.Int(nullable: false, identity: true),
                        BusinessName = c.String(nullable: false),
                        BusinessAdres1 = c.String(),
                        BusinessAdres2 = c.String(),
                        BusinessAdres3 = c.String(),
                        BusinessPostCode = c.String(nullable: false, maxLength: 50),
                        BusinessTelNo = c.String(nullable: false, maxLength: 50),
                        MobileNo = c.String(nullable: false, maxLength: 50),
                        EmailAdres = c.String(nullable: false, maxLength: 50),
                        Passwords = c.String(nullable: false, maxLength: 50),
                        CompanyNumber = c.String(nullable: false, maxLength: 50),
                        VatNumber = c.String(nullable: false, maxLength: 50),
                        PrimaryContact = c.String(nullable: false, maxLength: 50),
                        SecondaryContact = c.String(nullable: false, maxLength: 50),
                        BusinesType = c.String(nullable: false, maxLength: 50),
                        Other = c.String(nullable: false, maxLength: 50),
                        Tobacconist = c.String(nullable: false, maxLength: 50),
                        AreYou18 = c.String(nullable: false, maxLength: 50),
                        Depot = c.String(nullable: false, maxLength: 50),
                        BankName = c.String(nullable: false, maxLength: 50),
                        BankAdres1 = c.String(),
                        BankAdres2 = c.String(),
                        BankAdres3 = c.String(),
                        BankPostCode = c.String(maxLength: 50),
                        AccountName = c.String(maxLength: 50),
                        AccountNumber = c.String(maxLength: 50),
                        SortCode = c.String(maxLength: 50),
                        Requirements = c.String(maxLength: 50),
                        ActivePassive = c.Boolean(nullable: false),
                        Token = c.String(nullable: false, maxLength: 50),
                        Balance = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.BusinessId);
            
            CreateTable(
                "dbo.CargoDetail",
                c => new
                    {
                        CargoDesiId = c.Int(nullable: false, identity: true),
                        CargoParentId = c.Int(),
                        CargoDesiValue = c.Int(),
                        CargoDesiPrice = c.String(maxLength: 50),
                        CargoDesiCityId = c.Int(),
                    })
                .PrimaryKey(t => t.CargoDesiId);
            
            CreateTable(
                "dbo.Cargo",
                c => new
                    {
                        CargoId = c.Int(nullable: false, identity: true),
                        CargoName = c.String(nullable: false, maxLength: 50),
                        CreatedDate = c.DateTime(nullable: false),
                        CargoImage = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.CargoId);
            
            CreateTable(
                "dbo.CargoTracking",
                c => new
                    {
                        CargoTrackingId = c.Int(nullable: false, identity: true),
                        CargoTrackingNumber = c.String(nullable: false, maxLength: 50),
                        CargoTrackingLink = c.String(nullable: false),
                        OrderId = c.Int(nullable: false),
                        OrderDetailId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CargoTrackingId);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 50),
                        SubCategoryId = c.Int(nullable: false),
                        ActivePassive = c.Boolean(nullable: false),
                        CategoryImage = c.String(nullable: false, maxLength: 50),
                        CategoryBanner = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.City",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        ProvincialIdentificationNo = c.Int(nullable: false),
                        CityName = c.String(nullable: false, maxLength: 50),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CityId);
            
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        CompanySeo = c.String(nullable: false, maxLength: 50),
                        CompanyName = c.String(nullable: false, maxLength: 50),
                        CompanyTitle = c.String(maxLength: 50),
                        CompanyPassword = c.String(nullable: false, maxLength: 50),
                        CompanyImage = c.String(nullable: false, maxLength: 50),
                        CompanyDescription = c.String(nullable: false),
                        CompanyFacebook = c.String(maxLength: 50),
                        CompanyTwitter = c.String(maxLength: 50),
                        CompanyGoogle = c.String(maxLength: 50),
                        CompanyCountry = c.String(nullable: false, maxLength: 50),
                        CompanyCity = c.String(nullable: false, maxLength: 50),
                        CompanyCounty = c.String(nullable: false, maxLength: 50),
                        CompanyDistrict = c.String(nullable: false, maxLength: 50),
                        CompanyStreet = c.String(nullable: false, maxLength: 50),
                        CompanyAddress = c.String(nullable: false),
                        CompanyNumber = c.String(maxLength: 50),
                        CompanyPhone = c.String(maxLength: 50),
                        CompanyGsm = c.String(maxLength: 50),
                        CompanyEmail = c.String(maxLength: 50),
                        CompanyWeb = c.String(maxLength: 50),
                        CompanyMap = c.String(),
                        CompanyPaid = c.Boolean(),
                        CompanyRegistration = c.String(maxLength: 50),
                        CompanySector = c.Int(),
                        ActivePassive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            CreateTable(
                "dbo.ContentPage",
                c => new
                    {
                        PageId = c.Int(nullable: false, identity: true),
                        PageName = c.String(nullable: false, maxLength: 50),
                        PageContent = c.String(nullable: false),
                        PageImage = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.PageId);
            
            CreateTable(
                "dbo.Country",
                c => new
                    {
                        CountryId = c.Int(nullable: false, identity: true),
                        CountryName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.CountryId);
            
            CreateTable(
                "dbo.CustomerDetail",
                c => new
                    {
                        CustomerDetailId = c.Int(nullable: false, identity: true),
                        CustomerDetailName = c.String(nullable: false, maxLength: 50),
                        CustomerDetailSurname = c.String(nullable: false, maxLength: 50),
                        EmailAdress = c.String(nullable: false, maxLength: 50),
                        AddressName = c.String(nullable: false, maxLength: 50),
                        CompanyName = c.String(nullable: false, maxLength: 250),
                        TaxAdministration = c.String(nullable: false, maxLength: 50),
                        TaxNumber = c.String(nullable: false, maxLength: 11, fixedLength: true, unicode: false),
                        Phone = c.String(nullable: false, maxLength: 50),
                        GSM = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false),
                        CityId = c.Int(nullable: false),
                        DistrictId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerDetailId);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false, maxLength: 50),
                        CustomerSurname = c.String(nullable: false, maxLength: 50),
                        EmailAddress = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        MembershipDate = c.DateTime(nullable: false),
                        ActivePassive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.District",
                c => new
                    {
                        DistrictId = c.Int(nullable: false, identity: true),
                        IndentityNumber = c.Int(nullable: false),
                        DistrictName = c.String(nullable: false, maxLength: 50),
                        ProvincialIdentificationNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DistrictId);
            
            CreateTable(
                "dbo.FilterDetail",
                c => new
                    {
                        FilterDetailId = c.Int(nullable: false, identity: true),
                        FilterDetailTitle = c.String(nullable: false, maxLength: 50),
                        FilterId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FilterDetailId);
            
            CreateTable(
                "dbo.Filter",
                c => new
                    {
                        FilterId = c.Int(nullable: false, identity: true),
                        FilterTitle = c.String(nullable: false, maxLength: 50),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FilterId);
            
            CreateTable(
                "dbo.FilterProduct",
                c => new
                    {
                        FilterProductId = c.Int(nullable: false, identity: true),
                        FilterDetailId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FilterProductId);
            
            CreateTable(
                "dbo.OrderDetail",
                c => new
                    {
                        OrderDetailId = c.Int(nullable: false, identity: true),
                        OrderTopId = c.Int(nullable: false),
                        OrderDetailProductId = c.Int(nullable: false),
                        OrderDetailProductImage = c.String(nullable: false, maxLength: 50),
                        OrderDetailProductName = c.String(nullable: false, maxLength: 50),
                        OrderDetailProductPrice = c.String(nullable: false, maxLength: 50),
                        OrderDetailProductPiece = c.Int(nullable: false),
                        OrderDetailProductKdv = c.String(nullable: false, maxLength: 50),
                        OrderDetailProductStatus = c.Int(nullable: false),
                        OrderDetailProductDiscount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderDetailId);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        OrderDate = c.String(nullable: false, maxLength: 50),
                        OrderDeliveryDate = c.String(nullable: false, maxLength: 50),
                        OrderStatu = c.Int(nullable: false),
                        OrderPaymentOptionDepositCard = c.Int(nullable: false),
                        OrderPaymentCard = c.Int(nullable: false),
                        OrderPaymentCardResult = c.String(nullable: false),
                        OrderPaymentStructuredIp = c.String(nullable: false, maxLength: 50),
                        OrderPaymentCardPin = c.String(nullable: false),
                        OrderPaymentInstallmentNumber = c.String(nullable: false),
                        OrderTotalVAT = c.String(nullable: false, maxLength: 50),
                        PriceExcludingOrderVAT = c.String(nullable: false, maxLength: 50),
                        PriceIncludingOrderTotalVAT = c.String(nullable: false, maxLength: 50),
                        OrderTotalCargoPrice = c.String(nullable: false, maxLength: 50),
                        TotalOrder = c.Int(nullable: false),
                        OrderMemberId = c.Int(nullable: false),
                        OrderMemberName = c.String(nullable: false, maxLength: 50),
                        OrderMemberSurname = c.String(nullable: false, maxLength: 50),
                        OrderMemberEmail = c.String(nullable: false, maxLength: 50),
                        OrderMemberCompany = c.String(nullable: false, maxLength: 50),
                        OrderMemberTaxOffice = c.String(nullable: false, maxLength: 50),
                        OrderMemberTaxNumber = c.String(nullable: false, maxLength: 50),
                        OrderMemberGsm = c.String(nullable: false, maxLength: 50),
                        OrderMemberPhone = c.String(nullable: false, maxLength: 50),
                        OrderMemberCity = c.String(nullable: false, maxLength: 50),
                        OrderMemberDistrict = c.String(nullable: false, maxLength: 50),
                        OrderMemberAddress = c.String(nullable: false, maxLength: 250),
                        OrderNote = c.String(nullable: false, maxLength: 250),
                        OrderInvoiceName = c.String(nullable: false, maxLength: 50),
                        OrderInvoiceSurname = c.String(nullable: false, maxLength: 50),
                        OrderInvoiceEmail = c.String(nullable: false, maxLength: 50),
                        OrderInvoiceCompany = c.String(nullable: false, maxLength: 50),
                        OrderInvoiceTaxAdministration = c.String(nullable: false, maxLength: 50),
                        OrderInvoiceTaxNumber = c.String(nullable: false, maxLength: 50),
                        OrderInvoiceGsm = c.String(nullable: false, maxLength: 50),
                        OrderInvoicePhone = c.String(nullable: false, maxLength: 50),
                        OrderInvoiceCity = c.String(nullable: false, maxLength: 50),
                        OrderInvoiceDistrict = c.String(nullable: false, maxLength: 50),
                        OrderInvoiceAddress = c.String(nullable: false, maxLength: 250),
                        OrderInvoiceTrackingNumber = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.OrderId);
            
            CreateTable(
                "dbo.OrderStatusy",
                c => new
                    {
                        OrderStatuId = c.Int(nullable: false, identity: true),
                        OrderStatu = c.String(nullable: false, maxLength: 50),
                        OrderStatuColor = c.String(nullable: false, maxLength: 50),
                        ActivePassive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.OrderStatuId);
            
            CreateTable(
                "dbo.ProductFilter",
                c => new
                    {
                        ProductFilterId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        FilterId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductFilterId);
            
            CreateTable(
                "dbo.ProductImage",
                c => new
                    {
                        ImageId = c.Int(nullable: false, identity: true),
                        Path = c.String(nullable: false, maxLength: 250),
                        ProductId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ImageId);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 50),
                        ProductPrice = c.Decimal(nullable: false, storeType: "money"),
                        ReferralPrice = c.Decimal(nullable: false, storeType: "money"),
                        Rsp = c.String(nullable: false, maxLength: 50),
                        ProductShortDescription = c.String(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        BrandId = c.Int(nullable: false),
                        ProductCategory = c.Int(nullable: false),
                        ProductDescription = c.String(nullable: false),
                        ActivePassive = c.Boolean(nullable: false),
                        ProductHit = c.Int(nullable: false),
                        Sku = c.String(nullable: false, maxLength: 50),
                        Stock = c.Int(nullable: false),
                        WatCode = c.Int(nullable: false),
                        ProductCriterion = c.Int(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        SpeacilPrice = c.Decimal(nullable: false, storeType: "money"),
                        MustStockLine = c.Boolean(nullable: false),
                        Por = c.String(nullable: false, maxLength: 50),
                        BarcodeCode = c.String(nullable: false, maxLength: 50),
                        UpdateDate = c.DateTime(nullable: false),
                        CargoPrice = c.Int(nullable: false),
                        N11 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.Sector",
                c => new
                    {
                        SectorId = c.Int(nullable: false, identity: true),
                        SectorName = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.SectorId);
            
            CreateTable(
                "dbo.Setting",
                c => new
                    {
                        SettingId = c.Int(nullable: false, identity: true),
                        BasketLimitKeeps = c.String(nullable: false, maxLength: 50),
                        OrderEmailAddress = c.String(nullable: false, maxLength: 50),
                        ContactMailAddress = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 50),
                        PostCode = c.String(nullable: false, maxLength: 50),
                        CompanyName = c.String(nullable: false, maxLength: 50),
                        GSM = c.String(maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 50),
                        Phone2 = c.String(maxLength: 50),
                        Fax = c.String(maxLength: 50),
                        Map = c.String(nullable: false),
                        CompanyNumber = c.String(nullable: false, maxLength: 50),
                        Slogan = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.SettingId);
            
            CreateTable(
                "dbo.ShowcaseCompany",
                c => new
                    {
                        ShowcaseId = c.Int(nullable: false, identity: true),
                        CompanyId = c.Int(nullable: false),
                        ShowcaseNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ShowcaseId);
            
            CreateTable(
                "dbo.Showcase",
                c => new
                    {
                        ShowcaseId = c.Int(nullable: false, identity: true),
                        ShowcaseName = c.String(nullable: false, maxLength: 50),
                        ShowcaseSortNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ShowcaseId);
            
            CreateTable(
                "dbo.ShowcaseProduct",
                c => new
                    {
                        ShowcaseProductId = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        ShowcaseProductSort = c.Int(),
                        ShowcaseProductTopId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ShowcaseProductId);
            
            CreateTable(
                "dbo.Slider",
                c => new
                    {
                        SliderId = c.Int(nullable: false, identity: true),
                        SliderImage = c.String(nullable: false, maxLength: 50),
                        SliderUrl = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.SliderId);
            
            CreateTable(
                "dbo.Statistic",
                c => new
                    {
                        StatisticId = c.Int(nullable: false, identity: true),
                        IP = c.String(nullable: false, maxLength: 50),
                        Date = c.DateTime(nullable: false),
                        Page = c.String(nullable: false, maxLength: 50),
                        Language = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.StatisticId);
            
            CreateTable(
                "dbo.Town",
                c => new
                    {
                        TownId = c.Int(nullable: false, identity: true),
                        DistrictIdNumber = c.Int(nullable: false),
                        BucakIdNumber = c.Int(nullable: false),
                        TownIdNumber = c.Int(nullable: false),
                        IdNumber = c.Int(nullable: false),
                        TownName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TownId);
            
            CreateTable(
                "dbo.VirtualPosBank",
                c => new
                    {
                        BankId = c.Int(nullable: false, identity: true),
                        BankCode = c.String(nullable: false, maxLength: 50),
                        BankName = c.String(nullable: false, maxLength: 50),
                        Bank3DLink = c.String(nullable: false),
                        BankMemberId = c.String(nullable: false, maxLength: 50),
                        BankAnswer = c.String(nullable: false),
                        Bank3DSecurity = c.String(nullable: false, maxLength: 50),
                        BankImage = c.String(nullable: false, maxLength: 50),
                        AktivePassive = c.Boolean(nullable: false),
                        BankSort = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BankId);
            
            CreateTable(
                "dbo.VirtualPosInstallment",
                c => new
                    {
                        InstallmentId = c.Int(nullable: false, identity: true),
                        BankId = c.Int(nullable: false),
                        NumberOfInstallment = c.Int(nullable: false),
                        InstallmentRate = c.String(nullable: false, maxLength: 50),
                        ActivePassive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.InstallmentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VirtualPosInstallment");
            DropTable("dbo.VirtualPosBank");
            DropTable("dbo.Town");
            DropTable("dbo.Statistic");
            DropTable("dbo.Slider");
            DropTable("dbo.ShowcaseProduct");
            DropTable("dbo.Showcase");
            DropTable("dbo.ShowcaseCompany");
            DropTable("dbo.Setting");
            DropTable("dbo.Sector");
            DropTable("dbo.Product");
            DropTable("dbo.ProductImage");
            DropTable("dbo.ProductFilter");
            DropTable("dbo.OrderStatusy");
            DropTable("dbo.Order");
            DropTable("dbo.OrderDetail");
            DropTable("dbo.FilterProduct");
            DropTable("dbo.Filter");
            DropTable("dbo.FilterDetail");
            DropTable("dbo.District");
            DropTable("dbo.Customer");
            DropTable("dbo.CustomerDetail");
            DropTable("dbo.Country");
            DropTable("dbo.ContentPage");
            DropTable("dbo.Company");
            DropTable("dbo.City");
            DropTable("dbo.Category");
            DropTable("dbo.CargoTracking");
            DropTable("dbo.Cargo");
            DropTable("dbo.CargoDetail");
            DropTable("dbo.Busine");
            DropTable("dbo.Brand");
            DropTable("dbo.Banner");
            DropTable("dbo.Bank");
            DropTable("dbo.Administrator");
        }
    }
}
