using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConvensions
{
    public class ForignKeyDbContext : DbContext
    {
        public ForignKeyDbContext() : base("AssociationDbContextDB")
        {

        }

        public DbSet<Model.RelationshipConvention.ByForigenKey.Teacher> Teachers { get; set; }

        public DbSet<Model.RelationshipConvention.ByForigenKey.Student> Students { get; set; }
    }
}
