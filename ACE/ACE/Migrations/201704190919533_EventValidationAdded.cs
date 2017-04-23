namespace ACE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventValidationAdded : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Event", "EventName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Event", "EventDesc", c => c.String(maxLength: 150));
            AlterColumn("dbo.Event", "EventCountry", c => c.String(maxLength: 50));
            AlterColumn("dbo.Event", "EventCity", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Event", "EventCity", c => c.String());
            AlterColumn("dbo.Event", "EventCountry", c => c.String());
            AlterColumn("dbo.Event", "EventDesc", c => c.String());
            AlterColumn("dbo.Event", "EventName", c => c.String());
        }
    }
}
