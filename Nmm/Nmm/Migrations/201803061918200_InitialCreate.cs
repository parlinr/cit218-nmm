namespace Nmm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Breweries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        BreweryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Breweries", t => t.BreweryID, cascadeDelete: true)
                .Index(t => t.BreweryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "BreweryID", "dbo.Breweries");
            DropIndex("dbo.Reviews", new[] { "BreweryID" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Breweries");
        }
    }
}
