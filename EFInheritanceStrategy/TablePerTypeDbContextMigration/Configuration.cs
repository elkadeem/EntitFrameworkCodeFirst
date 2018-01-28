namespace EFInheritanceStrategy.TablePerTypeDbContextMigration
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFInheritanceStrategy.TablePerTypeDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"TablePerTypeDbContextMigration";
        }

        protected override void Seed(EFInheritanceStrategy.TablePerTypeDbContext context)
        {
            for (int i = 1; i <= 10; i++)
            {
                context.Persons.AddOrUpdate(c => c.Name, new Model.Employee
                {
                    Name = $"Employee{i}",
                    BirthDate = DateTime.Today,
                    DepartmentName = $"Department{i}",
                    Salary = i * 10,
                });
            }

            for (int i = 1; i <= 10; i++)
            {
                context.Persons.AddOrUpdate(c => c.Name, new Model.Student
                {
                    Name = $"Student{i}",
                    BirthDate = DateTime.Today,
                    Grade = $"Grade{i % 3}",
                    SupervisorName = $"SuperVisor{i % 3}",
                });
            }

            context.SaveChanges();
        }
    }
}
