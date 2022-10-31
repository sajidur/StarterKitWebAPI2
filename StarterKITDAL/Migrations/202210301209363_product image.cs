namespace StarterKITDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productimage : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProductImages", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductImages", "ImageUrl", c => c.Int(nullable: false));
        }
    }
}
