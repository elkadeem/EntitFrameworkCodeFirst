using EFInheritanceStrategy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFInheritanceStrategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //TablePerHierarchyDbContextTest();
            //TablePerTypeDbContextTest();
            TablePerConcreteDbContextTest();

            Console.WriteLine("Hellow");
            Console.ReadKey();
        }

        private static void TablePerHierarchyDbContextTest()
        {
            TablePerHierarchyDbContext tablePerHierarchyDbContext = new TablePerHierarchyDbContext();
            tablePerHierarchyDbContext.Database.Log = Console.Write;

            foreach (var item in tablePerHierarchyDbContext.Persons)
            {
                if (item is Employee)
                    Console.WriteLine($"Employee:{item.Name}");

                if (item is Student)
                    Console.WriteLine($"Student:{item.Name}");
            }

            // Select Employee
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("*************************Select Employees Only***************************");
            var employees = tablePerHierarchyDbContext.Persons.OfType<Employee>()
                .Where(c => c.DepartmentName == "Department2");

            foreach (Employee item in employees)
            {
                Console.WriteLine($"Employee:{item.Name}");
            }

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("*************************Select Student Only***************************");
            var students = tablePerHierarchyDbContext.Persons.OfType<Student>()
                .Where(c => c.Grade == "Grade1");

            foreach (Student item in students)
            {
                Console.WriteLine($"Student:{item.Name}");
            }
        }

        private static void TablePerTypeDbContextTest()
        {
            TablePerTypeDbContext dbContext = new TablePerTypeDbContext();
            dbContext.Database.Log = Console.Write;

            foreach (var item in dbContext.Persons)
            {
                if (item is Employee)
                    Console.WriteLine($"Employee:{item.Name}");

                if (item is Student)
                    Console.WriteLine($"Student:{item.Name}");
            }

            // Select Employee
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("*************************Select Employees Only***************************");
            var employees = dbContext.Persons.OfType<Employee>()
                .Where(c => c.DepartmentName == "Department2");

            foreach (Employee item in employees)
            {
                Console.WriteLine($"Employee:{item.Name}");
            }

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("*************************Select Student Only***************************");
            var students = dbContext.Persons.OfType<Student>()
                .Where(c => c.Grade == "Grade1");

            foreach (Student item in students)
            {
                Console.WriteLine($"Student:{item.Name}");
            }
        }

        private static void TablePerConcreteDbContextTest()
        {
            TablePerConcreteDbContext dbContext = new TablePerConcreteDbContext();
            dbContext.Database.Log = Console.Write;

            foreach (var item in dbContext.Persons)
            {
                if (item is Employee)
                    Console.WriteLine($"Employee:{item.Name}");

                if (item is Student)
                    Console.WriteLine($"Student:{item.Name}");
            }

            // Select Employee
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("*************************Select Employees Only***************************");
            var employees = dbContext.Persons.OfType<Employee>()
                .Where(c => c.DepartmentName == "Department2");

            foreach (Employee item in employees)
            {
                Console.WriteLine($"Employee:{item.Name}");
            }

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("*************************Select Student Only***************************");
            var students = dbContext.Persons.OfType<Student>()
                .Where(c => c.Grade == "Grade1");

            foreach (Student item in students)
            {
                Console.WriteLine($"Student:{item.Name}");
            }
        }
    }
}
