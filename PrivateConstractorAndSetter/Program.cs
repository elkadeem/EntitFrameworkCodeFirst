using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateConstractorAndSetter
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckPrivateDbContext dbContext = new CheckPrivateDbContext();
            foreach(var employee in dbContext.Employees)
            {
                Console.WriteLine($"Employee: {employee.Id}-{employee.Name}-{employee.BirthDate}");
            }

            Console.ReadLine();
        }
    }
}
