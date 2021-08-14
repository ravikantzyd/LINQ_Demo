using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ_Paging
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPageView = 4;

            do
            {
                Console.WriteLine("Enter Page Number ...");

                if (int.TryParse(Console.ReadLine(), out int PageNumber))
                {
                    var ms = GetEmployees().Skip((PageNumber - 1) * totalPageView).Take(totalPageView);

                    foreach (var item in ms)
                    {
                        Console.WriteLine("Id : " + item.Id + " Name : " + item.Name);
                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid page number .....");
                }

            } while (true);            
        }

        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ Id =1, Name= "Ravi" },
                new Employee(){ Id =2, Name= "Krishna" },
                new Employee(){ Id =3, Name= "Shashi" },
                new Employee(){ Id =4, Name= "Cho" },
                new Employee(){ Id =5, Name= "Moe Moe" },
                new Employee(){ Id =6, Name= "Ravi" },
                new Employee(){ Id =7, Name= "Krishna" },
                new Employee(){ Id =8, Name= "Shashi" },
                new Employee(){ Id =9, Name= "Cho" },
                new Employee(){ Id =10, Name= "Moe Moe" },
                new Employee(){ Id =11, Name= "Ravi" },
                new Employee(){ Id =12, Name= "Krishna" },
                new Employee(){ Id =13, Name= "Shashi" },
                new Employee(){ Id =14, Name= "Cho" },
                new Employee(){ Id =15, Name= "Moe Moe" }
            };

            return employees;
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
