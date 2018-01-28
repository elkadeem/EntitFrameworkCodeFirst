using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConvensions.Model
{
    public class Person
    {
        public int PersonId { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string City { get; set; }
    }
}
