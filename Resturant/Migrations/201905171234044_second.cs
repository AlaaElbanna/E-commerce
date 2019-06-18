namespace Resturant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Resturants", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Resturants", "Address");
        }
    }
}
