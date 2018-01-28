namespace EFInheritanceStrategy.TablePerConcreteDbContextMigration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        DepartmentName = c.String(),
                        Salary = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Grade = c.String(),
                        SupervisorName = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            //Solve Primary key Problem
            Sql("DBCC CHECKIDENT ('Students', RESEED, 1)");
            Sql("DBCC CHECKIDENT ('Employees', RESEED, 100)");

        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
            DropTable("dbo.Employees");
        }
    }
}
