namespace HardwareAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CountryChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Brands", "Country", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Brands", "Country");
        }
    }
}
