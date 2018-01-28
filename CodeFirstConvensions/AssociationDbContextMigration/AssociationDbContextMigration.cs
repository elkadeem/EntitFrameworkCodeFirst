namespace CodeFirstConvensions.AssociationDbContextMigration
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class AssociationDbContextMigration : DbMigrationsConfiguration<CodeFirstConvensions.AssociationDbContext>
    {
        public AssociationDbContextMigration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"AssociationDbContextMigration";
            
        }

        protected override void Seed(CodeFirstConvensions.AssociationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
