namespace Resturant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ResturantRates",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Rate = c.Int(nullable: false),
                        Comment = c.String(),
                        RestID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Resturants", t => t.RestID, cascadeDelete: true)
                .Index(t => t.RestID);
            
            CreateTable(
                "dbo.Resturants",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Place = c.String(),
                        Rate = c.Int(nullable: false),
                        Menu = c.String(),
                        ResturantPhoto = c.String(),
                        Descrtption = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ResturantRates", "RestID", "dbo.Resturants");
            DropIndex("dbo.ResturantRates", new[] { "RestID" });
            DropTable("dbo.Resturants");
            DropTable("dbo.ResturantRates");
        }
    }
}
