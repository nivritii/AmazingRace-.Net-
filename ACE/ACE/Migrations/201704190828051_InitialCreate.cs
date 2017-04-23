namespace ACE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Event",
                c => new
                    {
                        EventID = c.Int(nullable: false, identity: true),
                        EventName = c.String(),
                        EventDesc = c.String(),
                        EventCountry = c.String(),
                        EventCity = c.String(),
                        EventStartDate = c.DateTime(nullable: false),
                        EventEndDate = c.DateTime(nullable: false),
                        EventTotalPitStops = c.Int(nullable: false),
                        EventTotalTeams = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EventID);
            
            CreateTable(
                "dbo.PitStop",
                c => new
                    {
                        PitStopID = c.Int(nullable: false, identity: true),
                        EventID = c.Int(nullable: false),
                        PitStopName = c.String(),
                        PitStopOrder = c.Int(nullable: false),
                        PitStopLocation = c.String(),
                        StaffID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PitStopID)
                .ForeignKey("dbo.Event", t => t.EventID, cascadeDelete: true)
                .ForeignKey("dbo.Staff", t => t.StaffID, cascadeDelete: true)
                .Index(t => t.EventID)
                .Index(t => t.StaffID);
            
            CreateTable(
                "dbo.Staff",
                c => new
                    {
                        StaffID = c.Int(nullable: false, identity: true),
                        StaffCode = c.String(),
                        StaffName = c.String(),
                        TeamStaff = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.StaffID);
            
            CreateTable(
                "dbo.Team",
                c => new
                    {
                        TeamID = c.Int(nullable: false, identity: true),
                        TeamName = c.String(),
                        EventID = c.Int(nullable: false),
                        Staff_StaffID = c.Int(),
                    })
                .PrimaryKey(t => t.TeamID)
                .ForeignKey("dbo.Event", t => t.EventID, cascadeDelete: true)
                .ForeignKey("dbo.Staff", t => t.Staff_StaffID)
                .Index(t => t.EventID)
                .Index(t => t.Staff_StaffID);
            
            CreateTable(
                "dbo.Member",
                c => new
                    {
                        MemberID = c.Int(nullable: false, identity: true),
                        MemberName = c.String(),
                        TeamID = c.Int(nullable: false),
                        MemberContact = c.String(),
                        MemberEmail = c.String(),
                        MemberPhoto = c.Binary(),
                    })
                .PrimaryKey(t => t.MemberID)
                .ForeignKey("dbo.Team", t => t.TeamID, cascadeDelete: true)
                .Index(t => t.TeamID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Team", "Staff_StaffID", "dbo.Staff");
            DropForeignKey("dbo.Member", "TeamID", "dbo.Team");
            DropForeignKey("dbo.Team", "EventID", "dbo.Event");
            DropForeignKey("dbo.PitStop", "StaffID", "dbo.Staff");
            DropForeignKey("dbo.PitStop", "EventID", "dbo.Event");
            DropIndex("dbo.Member", new[] { "TeamID" });
            DropIndex("dbo.Team", new[] { "Staff_StaffID" });
            DropIndex("dbo.Team", new[] { "EventID" });
            DropIndex("dbo.PitStop", new[] { "StaffID" });
            DropIndex("dbo.PitStop", new[] { "EventID" });
            DropTable("dbo.Member");
            DropTable("dbo.Team");
            DropTable("dbo.Staff");
            DropTable("dbo.PitStop");
            DropTable("dbo.Event");
        }
    }
}
