namespace DJProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Start : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserProfile",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.BrodCast",
                c => new
                    {
                        BrodCastId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BrodCastId);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        EventName = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(nullable: false),
                        Plase = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.EventId);
            
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        SongsID = c.Int(nullable: false, identity: true),
                        SongName = c.String(nullable: false),
                        Path = c.String(nullable: false),
                        Starts = c.Int(nullable: false),
                        SongType = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.SongsID);
            
            CreateTable(
                "dbo.Fidback",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Email = c.String(),
                        Commant = c.String(nullable: false),
                        Time = c.DateTime(nullable: false),
                        BrodCastId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CommentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fidback");
            DropTable("dbo.Songs");
            DropTable("dbo.Events");
            DropTable("dbo.BrodCast");
            DropTable("dbo.UserProfile");
        }
    }
}
