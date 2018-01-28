using PrivateConstractorAndSetter.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateConstractorAndSetter
{
    public class CheckPrivateDbContext : DbContext
    {
        public CheckPrivateDbContext() : base("CheckPrivateDbContext")
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
