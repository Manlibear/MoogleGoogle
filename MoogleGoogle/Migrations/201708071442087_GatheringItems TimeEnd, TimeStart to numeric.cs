namespace MoogleGoogle.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GatheringItemsTimeEndTimeStarttonumeric : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GatheringItems", "TimeStart", c => c.Double(nullable: false));
            AlterColumn("dbo.GatheringItems", "TimeEnd", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GatheringItems", "TimeEnd", c => c.String());
            AlterColumn("dbo.GatheringItems", "TimeStart", c => c.String());
        }
    }
}
