using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFStoredProcedure
{
    public class SPDbContext : DbContext
    {
        public SPDbContext() : base("SPDbContextDB")
        {

        }

        public DbSet<Employee> Employee { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasKey(c => c.Id);             
               
            modelBuilder.Entity<Employee>().Property(c => c.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            //modelBuilder.Entity<Employee>().HasKey(c => c.Id);
            //.MapToStoredProcedures();

            //Map all to stored procedure
            //modelBuilder.Types().Configure(t => t.MapToStoredProcedures());

            //modelBuilder.Entity<Employee>().MapToStoredProcedures(s => s.Update(e => e.HasName("ModifyEmployee")));

            modelBuilder.Entity<Employee>().MapToStoredProcedures(s =>
            {
                s.Update(u => u.HasName("ModifyEmployee"));
                s.Delete(d => d.HasName("DeleteEmployee"));
                s.Insert(i => i.HasName("InsertEmployee"));
            });
        }
    }
}
