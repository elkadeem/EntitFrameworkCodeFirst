using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConvensions
{
    public class AssociationDbContext : DbContext
    {
        public AssociationDbContext() : base("AssociationDbContextDB")
        {
            
        }

        public DbSet<Model.RelationshipConvention.ByAssociation.Teacher> Teachers { get; set; }

        public DbSet<Model.RelationshipConvention.ByAssociation.Student> Students { get; set; }
    }
}
