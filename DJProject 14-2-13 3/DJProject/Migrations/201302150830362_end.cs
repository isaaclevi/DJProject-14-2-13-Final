namespace DJProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class end : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Songs", "UpLoadDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Songs", "Starts");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Songs", "Starts", c => c.Int(nullable: false));
            DropColumn("dbo.Songs", "UpLoadDate");
        }
    }
}
