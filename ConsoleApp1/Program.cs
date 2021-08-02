using LINQ_DEMO4;
using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> datasource = new List<Employee>
            {
                new Employee(){Id=1,Name="Ravi Kant",Email="ravikant.zyd@gmail.com",Programming=new List<string>{ "C#","Java","LINQ"} },
                new Employee(){Id=2,Name="Krishna Kant",Email="krishnakant.zyd@gmail.com",Programming=new List<string>{ "Android","IOS","LINQ"} },
                new Employee(){Id=3,Name="Shashi Kant",Email="shashikant.zyd@gmail.com",Programming=new List<string>{ "Sql","Java","C#"} },
            };

            var selectManyMethod = datasource.SelectMany(emp => emp.Programming);

            var selectManyQuery = (from emp in datasource
                                   from skill in emp.Programming
                                   select skill).ToList();

            foreach (var item in selectManyQuery)
            {
                Console.WriteLine("Programming = " + item);
            }

            Console.ReadLine();
        }
    }
}
