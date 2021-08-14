using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ_GroupJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(){ Id = 1, Name = "Ravi Kant", CategoryId = 1 },
                new Student(){ Id = 2, Name = "Krishna Kant", CategoryId = 1 },
                new Student(){ Id = 3, Name = "Shashi Kant", CategoryId = 2 },
                new Student(){ Id = 4, Name = "Cho Cho Myint", CategoryId = 2 },
                new Student(){ Id = 5, Name = "Moe Moe", CategoryId = 3 },
            };

            List<Category> categories = new List<Category>()
            {
                new Category(){ Id = 1, Name = "IT" },
                new Category(){ Id = 2, Name = "Software Service" },
                new Category(){ Id = 3, Name = "Development" }
            };

            var qs = (from c in categories
                      join std in students
                      on c.Id equals std.CategoryId into GroupValue
                      select new { c, GroupValue }).ToList();

            foreach (var item in qs)
            {
                Console.WriteLine(item.c.Name + " Category Data ....");                

                foreach (var std in item.GroupValue)
                {
                    Console.WriteLine("Name : " + std.Name);
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
