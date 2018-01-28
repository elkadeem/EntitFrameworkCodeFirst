using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConvensions
{
    public class BothEndsDbContext : DbContext
    {
        public BothEndsDbContext() : base("BothEndsDbContectDB")
        {

        }

        public DbSet<Model.RelationshipConvention.BothEnds.Teacher> Teachers { get; set; }

        public DbSet<Model.RelationshipConvention.BothEnds.Student> Students { get; set; }
    }
}
