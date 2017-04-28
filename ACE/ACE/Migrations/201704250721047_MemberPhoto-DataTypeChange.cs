namespace ACE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MemberPhotoDataTypeChange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Member", "MemberPhoto", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Member", "MemberPhoto", c => c.Binary());
        }
    }
}
