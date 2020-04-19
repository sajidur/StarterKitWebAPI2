namespace StarterKITDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Conditions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IFCondition = c.String(),
                        ISConditions = c.String(),
                        ISValueConditions = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RulesId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rules", t => t.RulesId, cascadeDelete: true)
                .Index(t => t.RulesId);
            
            CreateTable(
                "dbo.Rules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SalaryItemId = c.String(),
                        IsFixedFigure = c.Boolean(nullable: false),
                        IsRelatedTo = c.Boolean(nullable: false),
                        RelatedToItemId = c.Int(nullable: false),
                        RelatedPercentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DeductionAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AdditionAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CountryId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedBy = c.Int(nullable: false),
                        SalaryItem_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .ForeignKey("dbo.SalaryItems", t => t.SalaryItem_Id)
                .Index(t => t.CountryId)
                .Index(t => t.SalaryItem_Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SalaryItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Descriptions = c.String(),
                        CountryId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        CompanyId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        UpdatedBy = c.Int(nullable: false),
                        Country_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.Country_Id)
                .Index(t => t.Country_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Country_Id", "dbo.Countries");
            DropForeignKey("dbo.Rules", "SalaryItem_Id", "dbo.SalaryItems");
            DropForeignKey("dbo.SalaryItems", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Rules", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Conditions", "RulesId", "dbo.Rules");
            DropIndex("dbo.Users", new[] { "Country_Id" });
            DropIndex("dbo.SalaryItems", new[] { "CountryId" });
            DropIndex("dbo.Rules", new[] { "SalaryItem_Id" });
            DropIndex("dbo.Rules", new[] { "CountryId" });
            DropIndex("dbo.Conditions", new[] { "RulesId" });
            DropTable("dbo.Users");
            DropTable("dbo.SalaryItems");
            DropTable("dbo.Countries");
            DropTable("dbo.Rules");
            DropTable("dbo.Conditions");
        }
    }
}
