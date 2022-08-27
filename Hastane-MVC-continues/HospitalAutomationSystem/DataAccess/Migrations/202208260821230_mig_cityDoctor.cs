namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_cityDoctor : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Hospitals", "CityID", "dbo.Cities");
            DropIndex("dbo.Hospitals", new[] { "CityID" });
            DropColumn("dbo.Hospitals", "CityID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Hospitals", "CityID", c => c.Int(nullable: false));
            CreateIndex("dbo.Hospitals", "CityID");
            AddForeignKey("dbo.Hospitals", "CityID", "dbo.Cities", "CityID", cascadeDelete: true);
        }
    }
}
