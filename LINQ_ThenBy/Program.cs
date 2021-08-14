using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ_ThenBy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> datasource = new List<Employee>()
            {
                new Employee()
                {
                    Id=1,
                    FirstName="Ravi",
                    LastName="Kant",
                    Email="ravikant.zyd@gmail.com"
                },
                new Employee()
                {
                    Id=3,
                    FirstName="Ravi",
                    LastName="Lal",
                    Email="krishnakant.zyd@gmail.com"
                },
                new Employee()
                {
                    Id=4,
                    FirstName="Krishna",
                    LastName="Kant",
                    Email="shashikant.zyd@gmail.com"
                },
                new Employee()
                {
                    Id=2,
                    FirstName="Krishna",
                    LastName="Kumar",
                    Email="chochomyint.zyd@gmail.com"
                }
            };

            var methodSyntax = datasource.OrderBy(f => f.FirstName).ThenBy(l => l.LastName).ToList();

            var methodSyntax1 = datasource.OrderBy(f => f.FirstName).ThenBy(e => e.LastName).ThenBy(d=>d.Id).ToList();

            var methodSyntax2 = datasource.OrderByDescending(emp => emp.FirstName).ThenByDescending(e => e.LastName).ToList();

            var querySyntax = from emp in datasource
                              orderby emp.FirstName, emp.LastName, emp.Id
                              select emp;

            var querySyntax1 = from emp in datasource
                              orderby emp.FirstName descending, emp.LastName descending, emp.Id descending
                              select emp;

            foreach (var item in querySyntax1)
            {
                Console.WriteLine("Id : " + item.Id + " ,First Name : " + item.FirstName + " ,Last Name : " + item.LastName + " ,Email : " + item.Email);
            }

            Console.ReadLine();
        }
    }
}
