namespace Resturant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thir : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ResturantRates", "UserId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ResturantRates", "UserId");
        }
    }
}
