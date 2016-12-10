namespace HardwareAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FullNameChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Brands", "FullName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Brands", "FullName");
        }
    }
}
