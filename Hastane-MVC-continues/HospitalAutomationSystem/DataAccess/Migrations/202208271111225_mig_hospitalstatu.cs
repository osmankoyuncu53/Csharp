namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_hospitalstatu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hospitals", "HospitalStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Hospitals", "HospitalStatus");
        }
    }
}
