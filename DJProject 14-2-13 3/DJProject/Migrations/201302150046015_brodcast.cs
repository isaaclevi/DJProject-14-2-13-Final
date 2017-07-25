namespace DJProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class brodcast : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BrodCast", "BordCastName", c => c.String(nullable: false));
            AddColumn("dbo.BrodCast", "StartDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.BrodCast", "EndDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.BrodCast", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BrodCast", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.BrodCast", "EndDate");
            DropColumn("dbo.BrodCast", "StartDate");
            DropColumn("dbo.BrodCast", "BordCastName");
        }
    }
}
