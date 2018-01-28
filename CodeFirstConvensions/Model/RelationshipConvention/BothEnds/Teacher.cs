using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConvensions.Model.RelationshipConvention.BothEnds
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
