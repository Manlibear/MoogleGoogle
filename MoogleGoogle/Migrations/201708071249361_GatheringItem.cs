namespace MoogleGoogle.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GatheringItem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GatheringItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TimeStart = c.String(),
                        TimeEnd = c.String(),
                        Slot = c.String(),
                        Zone = c.String(),
                        Position = c.String(),
                        FastestRoute = c.String(),
                        Level = c.String(),
                        Perfecption = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GatheringItems");
        }
    }
}
