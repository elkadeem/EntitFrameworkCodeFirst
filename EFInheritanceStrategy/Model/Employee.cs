using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFInheritanceStrategy.Model
{
    public class Employee : Person
    {
        public string DepartmentName { get; set; }

        public double Salary { get; set; }
    }
}
