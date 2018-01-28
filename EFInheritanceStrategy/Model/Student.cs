using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFInheritanceStrategy.Model
{
    public class Student : Person
    {
        public string Grade { get; set; }

        public string SupervisorName { get; set; }
    }
}
