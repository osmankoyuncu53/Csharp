namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cities", "DistrictID", c => c.Int(nullable: false));
            CreateIndex("dbo.Cities", "DistrictID");
            AddForeignKey("dbo.Cities", "DistrictID", "dbo.Districts", "DistrictID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "DistrictID", "dbo.Districts");
            DropIndex("dbo.Cities", new[] { "DistrictID" });
            DropColumn("dbo.Cities", "DistrictID");
        }
    }
}
