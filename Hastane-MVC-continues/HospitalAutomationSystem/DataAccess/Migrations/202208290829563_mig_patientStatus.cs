namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_patientStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "PatientStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Patients", "PatientStatus");
        }
    }
}
