namespace HaftalikRapor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reports", "Rate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reports", "Rate", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
