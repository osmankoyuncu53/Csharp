namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class miguser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "UserPrimaryKey", c => c.String());
            DropColumn("dbo.Users", "UserName");
            DropColumn("dbo.Users", "UserPassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "UserPassword", c => c.String());
            AddColumn("dbo.Users", "UserName", c => c.String());
            DropColumn("dbo.Users", "UserPrimaryKey");
        }
    }
}
