using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConvensions
{
    public class CollectionDbContext : DbContext
    {
        public CollectionDbContext() : base("CollectionDbContext")
        {

        }

        public DbSet<Model.RelationshipConvention.ByCollection.Teacher> Teachers { get; set; }

        public DbSet<Model.RelationshipConvention.ByCollection.Student> Students { get; set; }
    }
}
