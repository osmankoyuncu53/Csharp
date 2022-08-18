namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class generalvt : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        AppointmentID = c.Int(nullable: false, identity: true),
                        AppointmentDate = c.DateTime(nullable: false),
                        AppointmentStatus = c.Boolean(nullable: false),
                        PatientID = c.Int(nullable: false),
                        DoctorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AppointmentID)
                .ForeignKey("dbo.Doctors", t => t.DoctorID, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientID, cascadeDelete: true)
                .Index(t => t.PatientID)
                .Index(t => t.DoctorID);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        DoctorID = c.Int(nullable: false, identity: true),
                        DoctorName = c.String(maxLength: 50),
                        DoctorSurname = c.String(maxLength: 50),
                        DoctorStatus = c.Boolean(nullable: false),
                        HospitalID = c.Int(nullable: false),
                        PoliclinicID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DoctorID)
                .ForeignKey("dbo.Hospitals", t => t.HospitalID, cascadeDelete: true)
                .ForeignKey("dbo.Policlinics", t => t.PoliclinicID, cascadeDelete: true)
                .Index(t => t.HospitalID)
                .Index(t => t.PoliclinicID);
            
            CreateTable(
                "dbo.Hospitals",
                c => new
                    {
                        HospitalID = c.Int(nullable: false, identity: true),
                        HospitalName = c.String(maxLength: 50),
                        CityID = c.Int(nullable: false),
                        DistrictID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HospitalID)
                .ForeignKey("dbo.Cities", t => t.CityID, cascadeDelete: true)
                .ForeignKey("dbo.Districts", t => t.DistrictID, cascadeDelete: true)
                .Index(t => t.CityID)
                .Index(t => t.DistrictID);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityID = c.Int(nullable: false, identity: true),
                        CityName = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.CityID);
            
            CreateTable(
                "dbo.Districts",
                c => new
                    {
                        DistrictID = c.Int(nullable: false, identity: true),
                        DistrictName = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.DistrictID);
            
            CreateTable(
                "dbo.Policlinics",
                c => new
                    {
                        PoliclinicID = c.Int(nullable: false, identity: true),
                        PoliclinicName = c.String(maxLength: 50),
                        PoliclinicStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PoliclinicID);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientID = c.Int(nullable: false, identity: true),
                        PatientName = c.String(maxLength: 50),
                        PatientSurname = c.String(maxLength: 50),
                        PatientIdentityNumber = c.String(maxLength: 11),
                        PatientPassword = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.PatientID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "PatientID", "dbo.Patients");
            DropForeignKey("dbo.Doctors", "PoliclinicID", "dbo.Policlinics");
            DropForeignKey("dbo.Doctors", "HospitalID", "dbo.Hospitals");
            DropForeignKey("dbo.Hospitals", "DistrictID", "dbo.Districts");
            DropForeignKey("dbo.Hospitals", "CityID", "dbo.Cities");
            DropForeignKey("dbo.Appointments", "DoctorID", "dbo.Doctors");
            DropIndex("dbo.Hospitals", new[] { "DistrictID" });
            DropIndex("dbo.Hospitals", new[] { "CityID" });
            DropIndex("dbo.Doctors", new[] { "PoliclinicID" });
            DropIndex("dbo.Doctors", new[] { "HospitalID" });
            DropIndex("dbo.Appointments", new[] { "DoctorID" });
            DropIndex("dbo.Appointments", new[] { "PatientID" });
            DropTable("dbo.Patients");
            DropTable("dbo.Policlinics");
            DropTable("dbo.Districts");
            DropTable("dbo.Cities");
            DropTable("dbo.Hospitals");
            DropTable("dbo.Doctors");
            DropTable("dbo.Appointments");
        }
    }
}
