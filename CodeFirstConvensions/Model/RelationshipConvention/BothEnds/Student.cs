using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConvensions.Model.RelationshipConvention.BothEnds
{
    public class Student
    {
        public int StudentId { get; set; }

        public string Name { get; set; }

        public Teacher Teacher { get; set; }
    }
}
