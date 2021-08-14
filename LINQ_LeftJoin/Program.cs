using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ_LeftJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(){ Id = 1, Name = "Ravi Kant", AddressId = 1 },
                new Student(){ Id = 2, Name = "Krishna Kant", AddressId = 1 },
                new Student(){ Id = 3, Name = "Shashi Kant" },
                new Student(){ Id = 4, Name = "Cho Cho Myint", AddressId = 2 },
                new Student(){ Id = 5, Name = "Moe Moe", AddressId = 1 },
            };

            List<Address> addresses = new List<Address>()
            {
                new Address(){ Id = 1, Line = "Line1" },
                new Address(){ Id = 2, Line = "Line2" },
                new Address(){ Id = 3, Line = "Line3" },                
            };

            var qs = (from std in students
                      join adds in addresses
                      on std.AddressId equals adds.Id into stdAdd
                      from address in stdAdd.DefaultIfEmpty()
                      select new
                      {
                          std,
                          address
                      }).ToList();

            foreach (var item in qs)
            {
                string address = item.address == null ? " NUll " : item.address.Line;

                Console.WriteLine($"Name : {item.std.Name} / Address : {address}");
            }

            Console.ReadLine();
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
    }

    public class Address
    {
        public int Id { get; set; }
        public string Line { get; set; }
    }
}
