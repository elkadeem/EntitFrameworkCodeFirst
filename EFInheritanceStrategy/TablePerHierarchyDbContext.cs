using EFInheritanceStrategy.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFInheritanceStrategy
{
    public class TablePerHierarchyDbContext : DbContext
    {
        public TablePerHierarchyDbContext() : base("TablePerHierarchyDbContextDB")
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}
