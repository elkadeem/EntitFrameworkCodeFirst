using EFInheritanceStrategy.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFInheritanceStrategy
{
    public class TablePerConcreteDbContext : DbContext
    {
        public TablePerConcreteDbContext() : base("TablePerConcreteDbContextDB")
        {

        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().Map(c => {
                c.MapInheritedProperties();
                c.ToTable("Employees");
                
            }).Property(c => c.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Student>().Map(c => {
                c.MapInheritedProperties();
                c.ToTable("Students");
            }).Property(c => c.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }
}
