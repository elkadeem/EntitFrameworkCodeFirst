namespace CodeFirstConvensions.Migrations
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
                    PersonId = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    BirthDate = c.DateTime(nullable: false),
                    Address = c.String(nullable: true),
                })
                .PrimaryKey(t => t.PersonId);



        }

        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
