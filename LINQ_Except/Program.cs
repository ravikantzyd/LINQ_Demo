using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LINQ_Except
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> datasource1 = new List<string>()
            {
                "A", "B", "C", "D"
            };

            List<string> datasource2 = new List<string>()
            {
                "E", "F", "C", "D"
            };

            List<Student> students = new List<Student>()
            {
                new Student(){ Id = 1, Name = "Ravi Kant" },
                new Student(){ Id = 2, Name = "Krishna Kant" },
                new Student(){ Id = 3, Name = "Ravi Kant" },
                new Student(){ Id = 3, Name = "Cho Cho Myint" },
                new Student(){ Id = 1, Name = "Ravi Kant" }
            };

            List<Student> student2 = new List<Student>()
            {
                new Student(){ Id = 1, Name = "Ravi Kant" },
                new Student(){ Id = 2, Name = "Krishna Kant" },
                new Student(){ Id = 3, Name = "Ravi Kant" },
                new Student(){ Id = 1, Name = "Ravi Kant" }
            };

            var ms1 = datasource1.Except(datasource2).ToList();

            var ms2 = students.Select(std=>std.Name).Except(student2.Select(std => std.Name)).ToList();

            var ms3 = students.Except(student2, new StudentComparer()).ToList();

            Console.ReadLine();
        }

        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class StudentComparer : IEqualityComparer<Student>
        {
            public bool Equals(Student x, Student y)
            {
                return x.Id.Equals(y.Id) && x.Name.Equals(y.Name);
            }

            public int GetHashCode([DisallowNull] Student obj)
            {
                int idHashCode = obj.Id.GetHashCode();
                int nameHashCode = obj.Name.GetHashCode();

                return idHashCode ^ nameHashCode;
            }
        }
    }
}
