namespace MoogleGoogle.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedGathingItemPerceptionspelling : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GatheringItems", "Perception", c => c.String());
            DropColumn("dbo.GatheringItems", "Perfecption");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GatheringItems", "Perfecption", c => c.String());
            DropColumn("dbo.GatheringItems", "Perception");
        }
    }
}
