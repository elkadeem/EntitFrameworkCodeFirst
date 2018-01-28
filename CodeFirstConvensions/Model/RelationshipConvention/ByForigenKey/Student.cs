using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConvensions.Model.RelationshipConvention.ByForigenKey
{
    public class Student
    {
        public int StudentId { get; set; }

        public string Name { get; set; } 
        
        public int TeacherId { get; set; }

        public Teacher Teacher { get; set; }
    }
}
