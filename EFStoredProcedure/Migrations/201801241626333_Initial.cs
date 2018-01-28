namespace EFStoredProcedure.Migrations
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
                    })
                .PrimaryKey(t => t.Id);
            
            CreateStoredProcedure(
                "dbo.InsertEmployee",
                p => new
                    {
                        Name = p.String(),
                        BirthDate = p.DateTime(),
                    },
                body:
                    @"INSERT [dbo].[Employees]([Name], [BirthDate])
                      VALUES (@Name, @BirthDate)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Employees]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Employees] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.ModifyEmployee",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                        BirthDate = p.DateTime(),
                    },
                body:
                    @"UPDATE [dbo].[Employees]
                      SET [Name] = @Name, [BirthDate] = @BirthDate
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.DeleteEmployee",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Employees]
                      WHERE ([Id] = @Id)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.DeleteEmployee");
            DropStoredProcedure("dbo.ModifyEmployee");
            DropStoredProcedure("dbo.InsertEmployee");
            DropTable("dbo.Employees");
        }
    }
}
