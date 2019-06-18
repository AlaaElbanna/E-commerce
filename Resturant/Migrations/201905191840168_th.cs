namespace Resturant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class th : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ResturantRates", "FeedbackRate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ResturantRates", "FeedbackRate");
        }
    }
}
