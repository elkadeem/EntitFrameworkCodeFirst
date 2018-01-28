using EFInheritanceStrategy.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFInheritanceStrategy
{
    public class TablePerTypeDbContext : DbContext
    {
        public TablePerTypeDbContext() : base("TablePerTypeDbContextDB")
        {

        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<Student>().ToTable("Students");
        }
    }
}
