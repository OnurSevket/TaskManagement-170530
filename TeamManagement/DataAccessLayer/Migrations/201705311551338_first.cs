namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false, maxLength: 50, unicode: false),
                        ContactName = c.String(nullable: false, maxLength: 50, unicode: false),
                        ContactTitle = c.String(nullable: false, maxLength: 50, unicode: false),
                        Address = c.String(nullable: false, maxLength: 200, unicode: false),
                        City = c.String(nullable: false, maxLength: 30, unicode: false),
                        Phone = c.String(),
                        Email = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Description = c.String(maxLength: 400),
                        PlannedStartDate = c.DateTime(nullable: false),
                        PlannedEndDate = c.DateTime(nullable: false),
                        State = c.String(maxLength: 50),
                        RealStartDate = c.DateTime(nullable: false),
                        RealEndDate = c.DateTime(nullable: false),
                        CustomerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Mail = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 20),
                        RoleID = c.Int(nullable: false),
                        LoginID = c.Int(nullable: false),
                        Work_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Logins", t => t.LoginID, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RoleID, cascadeDelete: true)
                .ForeignKey("dbo.Works", t => t.Work_ID)
                .Index(t => t.RoleID)
                .Index(t => t.LoginID)
                .Index(t => t.Work_ID);
            
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 60),
                        Password = c.String(maxLength: 4),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Requests",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProjectId = c.Int(nullable: false),
                        Type = c.String(),
                        Description = c.String(maxLength: 400),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Projects", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.ProjectId);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StateName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Works",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        Description = c.String(nullable: false, maxLength: 50, unicode: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        ProjectID = c.Int(nullable: false),
                        StateID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Projects", t => t.ProjectID, cascadeDelete: true)
                .ForeignKey("dbo.States", t => t.StateID, cascadeDelete: true)
                .Index(t => t.ProjectID)
                .Index(t => t.StateID);
            
            CreateTable(
                "dbo.ProjectEmployee",
                c => new
                    {
                        Project_ID = c.Int(nullable: false),
                        Employee_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Project_ID, t.Employee_ID })
                .ForeignKey("dbo.Projects", t => t.Project_ID, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.Employee_ID, cascadeDelete: true)
                .Index(t => t.Project_ID)
                .Index(t => t.Employee_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Works", "StateID", "dbo.States");
            DropForeignKey("dbo.Works", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.Employees", "Work_ID", "dbo.Works");
            DropForeignKey("dbo.Requests", "ProjectId", "dbo.Projects");
            DropForeignKey("dbo.ProjectEmployee", "Employee_ID", "dbo.Employees");
            DropForeignKey("dbo.ProjectEmployee", "Project_ID", "dbo.Projects");
            DropForeignKey("dbo.Employees", "RoleID", "dbo.Roles");
            DropForeignKey("dbo.Employees", "LoginID", "dbo.Logins");
            DropForeignKey("dbo.Projects", "CustomerID", "dbo.Customers");
            DropIndex("dbo.ProjectEmployee", new[] { "Employee_ID" });
            DropIndex("dbo.ProjectEmployee", new[] { "Project_ID" });
            DropIndex("dbo.Works", new[] { "StateID" });
            DropIndex("dbo.Works", new[] { "ProjectID" });
            DropIndex("dbo.Requests", new[] { "ProjectId" });
            DropIndex("dbo.Employees", new[] { "Work_ID" });
            DropIndex("dbo.Employees", new[] { "LoginID" });
            DropIndex("dbo.Employees", new[] { "RoleID" });
            DropIndex("dbo.Projects", new[] { "CustomerID" });
            DropTable("dbo.ProjectEmployee");
            DropTable("dbo.Works");
            DropTable("dbo.States");
            DropTable("dbo.Requests");
            DropTable("dbo.Roles");
            DropTable("dbo.Logins");
            DropTable("dbo.Employees");
            DropTable("dbo.Projects");
            DropTable("dbo.Customers");
        }
    }
}
