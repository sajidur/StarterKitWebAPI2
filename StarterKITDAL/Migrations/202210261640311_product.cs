namespace StarterKITDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class product : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NewsContents", "Order", c => c.Int(nullable: false));
            AlterColumn("dbo.ProductImages", "ProductId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductImages", "ProductId", c => c.Boolean(nullable: false));
            DropColumn("dbo.NewsContents", "Order");
        }
    }
}
