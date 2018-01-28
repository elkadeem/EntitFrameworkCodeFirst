namespace EFInheritanceStrategy.TablePerTypeDbContextMigration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        DepartmentName = c.String(),
                        Salary = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Grade = c.String(),
                        SupervisorName = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Id", "dbo.People");
            DropForeignKey("dbo.Employees", "Id", "dbo.People");
            DropIndex("dbo.Students", new[] { "Id" });
            DropIndex("dbo.Employees", new[] { "Id" });
            DropTable("dbo.Students");
            DropTable("dbo.Employees");
            DropTable("dbo.People");
        }
    }
}
