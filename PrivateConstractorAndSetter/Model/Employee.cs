using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateConstractorAndSetter.Model
{
    public class Employee
    {
        private Employee()
        {
        }

        public Employee(string name, DateTime birtDate)
        {
            this.Name = name;
            this.BirthDate = birtDate;
        }

        public int Id { get; private set; }

        public string Name { get; private set; }

        public DateTime BirthDate { get; private set; }

        
    }
}
