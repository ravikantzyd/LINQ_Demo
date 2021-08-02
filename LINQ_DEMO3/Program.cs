using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_DEMO3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{ID=1,Name="Ravi Kant",Email="ravikant.zyd@gmail.com" },
                new Employee{ID=2,Name="Krishna Kant",Email="krishnakant.zyd@gmail.com" },
                new Employee{ ID = 3, Name = "Shashi Kant", Email = "shashikant.zyd@gmail.com" }
            };

            IEnumerable<Employee> query1 = from employee in employees where employee.ID == 1 select employee;

            IQueryable<Employee> query2 = employees.AsQueryable().Where(e => e.ID == 1);

            foreach (var item in query1)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("Select Query Type 1 ........");

            var selectQuery1 = from emp in employees
                              select new Employee()
                              {
                                  ID=emp.ID,
                                  Name=emp.Name
                              };

            var selectQuery2 = from emp in employees
                               select new
                               {
                                   CustomId=emp.ID,
                                   CustomName=emp.Name,
                                   CustomeEmail=emp.Email
                               };

            foreach (var item in selectQuery1)
            {
                Console.WriteLine("ID = " + item.ID + " Name = " + item.Name + " Email = " + item.Email);
            }

            Console.WriteLine();
            Console.WriteLine("Select Query Type 2 .........");

            foreach (var item in selectQuery2)
            {
                Console.WriteLine("ID = " + item.CustomId + " Name = " + item.CustomName + " Email = " + item.CustomeEmail);
            }

            Console.WriteLine();
            Console.WriteLine("Select Method Query Type 1 .......");

            var selectMethodQuery1 = employees.Select(emp => new Employee
            {
                ID=emp.ID,
                Name=emp.Name,
                Email=emp.Email
            });

            foreach (var item in selectMethodQuery1)
            {
                Console.WriteLine("ID = " + item.ID + " Name = " + item.Name + " Email = " + item.Email);
            }

            Console.WriteLine();
            Console.WriteLine("Select Method Query Type 2 .....");

            var selectMethodQuery2 = employees.Select(emp => new
            {
                CustomId = emp.ID,
                CustomName = emp.Name,
                CustomeEmail = emp.Email
            });

            foreach (var item in selectMethodQuery2)
            {
                Console.WriteLine("ID = " + item.CustomId + " Name = " + item.CustomName + " Email = " + item.CustomeEmail);
            }

            Console.WriteLine();
            Console.WriteLine("Select Method Query Type 3 ........");

            var selectMethodQuery3 = employees.Select((emp, a) => new
            {
                Index=a,
                CustomeName=emp.Name
            });

            foreach (var item in selectMethodQuery3)
            {
                Console.WriteLine("Index = " + item.Index + " Name = " + item.CustomeName);
            }

            Console.ReadLine();
        }
    }

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
