namespace ACE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class multilinetextforpitstoplocation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PitStop", "PitStopLocation", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PitStop", "PitStopLocation", c => c.String(maxLength: 50));
        }
    }
}
