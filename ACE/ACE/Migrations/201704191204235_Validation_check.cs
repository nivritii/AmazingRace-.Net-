namespace ACE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Validation_check : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PitStop", "PitStopName", c => c.String(maxLength: 50));
            AlterColumn("dbo.PitStop", "PitStopLocation", c => c.String(maxLength: 50));
            AlterColumn("dbo.Staff", "StaffCode", c => c.String(maxLength: 8));
            AlterColumn("dbo.Staff", "StaffName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Team", "TeamName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Member", "MemberName", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Member", "MemberName", c => c.String());
            AlterColumn("dbo.Team", "TeamName", c => c.String());
            AlterColumn("dbo.Staff", "StaffName", c => c.String());
            AlterColumn("dbo.Staff", "StaffCode", c => c.String());
            AlterColumn("dbo.PitStop", "PitStopLocation", c => c.String());
            AlterColumn("dbo.PitStop", "PitStopName", c => c.String());
        }
    }
}
