namespace HardwareAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredChange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Brands", "Country", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Brands", "Country", c => c.String());
        }
    }
}
