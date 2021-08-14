
using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ_Join
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(){ Id = 1, Name = "Ravi Kant", AddressId = 1 },
                new Student(){ Id = 2, Name = "Krishna Kant", AddressId = 1 },
                new Student(){ Id = 3, Name = "Shashi Kant", AddressId = 0 },
                new Student(){ Id = 4, Name = "Cho Cho Myint", AddressId = 2 },
                new Student(){ Id = 5, Name = "Moe Moe", AddressId = 1 },
            };

            List<Address> addresses = new List<Address>()
            {
                new Address(){ Id = 1, Line = "Line1" },
                new Address(){ Id = 2, Line = "Line2" },
                new Address(){ Id = 3, Line = "Line3" },
                new Address(){ Id = 4, Line = "Line4" },
                new Address(){ Id = 5, Line = "Line5" },
            };

            List<Marks> marks = new List<Marks>()
            {
                new Marks(){ Id = 1, StudentId = 1, TMarks = 325 },
                new Marks(){ Id = 2, StudentId = 2, TMarks = 373 },
                new Marks(){ Id = 3, StudentId = 3, TMarks = 290 }
            };

            var ms1 = students.Join(addresses,
                        std => std.AddressId,
                        address => address.Id,
                        (std, address) => new
                        {
                            StudentName = std.Name,
                            StudentAddress = address.Line
                        }).ToList();

            var qs1 = (from std in students
                      join ads in addresses
                      on std.AddressId equals ads.Id
                      select new
                      {
                          StudentName = std.Name,
                          StudentAddress = ads.Line
                      }).ToList();

            var qs2 = from std in students
                      join ads in addresses
                      on std.AddressId equals ads.Id
                      join mark in marks
                      on std.Id equals mark.StudentId       
                      where std.Id == 1
                      select new
                      {
                          StudentName = std.Name,
                          StudentAddress = ads.Line,
                          TotalMark = mark.TMarks
                      };

            foreach (var item in qs2)
            {
                Console.WriteLine("Student Name : " + item.StudentName + " \t\t Student Address : " + item.StudentAddress +
                                    " \t\t Total Mark : " + item.TotalMark);
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

    public class Marks
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int TMarks { get; set; }
    }
}
