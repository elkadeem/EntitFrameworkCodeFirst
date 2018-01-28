using CodeFirstConvensions.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConvensions
{
    public class EFDbContext : DbContext
    {
        public EFDbContext() : base("CodeFirstConvensionsDB")
        {

        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
