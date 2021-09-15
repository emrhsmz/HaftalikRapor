namespace HaftalikRapor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateTableSecond : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reports", "Year", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reports", "Year");
        }
    }
}
