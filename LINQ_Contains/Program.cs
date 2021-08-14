using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LINQ_Contains
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(){ Id = 1, Name = "Ravi Kant" },
                new Student(){ Id = 2, Name = "Krishna Kant" },
                new Student(){ Id = 3, Name = "Shashi Kant" }
            };

            Student std = new Student()
            {
                Id = 4,
                Name = "Cho Cho Myint"
            };

            students.Add(std);

            //This is false because this Student object reference is different from List Student object reference.
            var isExits = students.Contains(new Student() { Id = 1, Name = "Ravi Kant" });

            //This is true because this Student object reference is same.
            var isExits1 = students.Contains(std);

            var compare = new StudentCompare();

            //This is from LINQ package.
            var isExits2 = students.Contains(new Student() { Id = 1, Name = "Ravi Kant" }, compare);

            var querySyntax = (from std1 in students
                               select std1).Contains(new Student() { Id = 1, Name = "Ravi Kant" }, compare);

            Console.ReadLine();
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class StudentCompare : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (object.ReferenceEquals(x, y))
            {
                return true;
            }

            if(object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null))
            {
                return false;
            }

            return x.Id == y.Id && x.Name == y.Name;
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
            if (obj == null)
            {
                return 0;
            }

            int IdHashCode = obj.Id.GetHashCode();
            int NameHashCode = obj.Name == null ? 0 : obj.Name.GetHashCode();

            return IdHashCode ^ NameHashCode;
        }
    }
}
