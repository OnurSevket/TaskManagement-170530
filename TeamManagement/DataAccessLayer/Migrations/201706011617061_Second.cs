namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Projects", "RealStartDate", c => c.DateTime());
            AlterColumn("dbo.Projects", "RealEndDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "RealEndDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Projects", "RealStartDate", c => c.DateTime(nullable: false));
        }
    }
}
