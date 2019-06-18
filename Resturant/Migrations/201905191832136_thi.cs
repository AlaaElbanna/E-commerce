namespace Resturant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thi : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ResturantRates", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ResturantRates", "UserId", c => c.Int(nullable: false));
        }
    }
}
