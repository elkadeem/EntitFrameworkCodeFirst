namespace PrivateConstractorAndSetter.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PrivateConstractorAndSetter.CheckPrivateDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PrivateConstractorAndSetter.CheckPrivateDbContext context)
        {
            for(int i = 1; i < 10; i++)
            {
                context.Employees.AddOrUpdate(c => c.Name, new Model.Employee($"name{i}", DateTime.Today));
            }

            context.SaveChanges();
        }
    }
}
