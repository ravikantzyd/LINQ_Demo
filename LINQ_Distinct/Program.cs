using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LINQ_Distinct
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> datasourceINT = new List<int>()
            {
                1, 2, 1, 3, 4, 5, 6, 2, 4, 5, 5, 3
            };

            List<Student> students = new List<Student>()
            {
                new Student(){ Id = 1, Name = "Ravi Kant" },
                new Student(){ Id = 2, Name = "Krishna Kant" },
                new Student(){ Id = 3, Name = "Ravi Kant" },
                new Student(){ Id = 1, Name = "Ravi Kant" }
            };

            List<Teacher> teachers = new List<Teacher>()
            {
                new Teacher(){ Id = 1, Name = "Ravi Kant" },
                new Teacher(){ Id = 2, Name = "Krishna Kant" },
                new Teacher(){ Id = 3, Name = "Ravi Kant" },
                new Teacher(){ Id = 1, Name = "Ravi Kant" }
            };

            var distinctMethod1 = datasourceINT.Distinct().ToList();

            var distinctMethod2 = students.Select(std => std.Name).Distinct().ToList();

            //This is used IEquatable.
            var distinctMethod3 = students.Distinct().ToList();

            //This is used IEqualityCompare.
            var distinctMethod4 = teachers.Distinct(new TeacherCompare()).ToList();            

            Console.ReadLine();

        }

        //If we need same object to compare then we used IEquatable.
        public class Student : IEquatable<Student>
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public bool Equals(Student other)
            {
                if (object.ReferenceEquals(other, null))
                {
                    return false;
                }

                if (object.ReferenceEquals(this, other))
                {
                    return true;
                }

                return Id.Equals(other.Id) && Name.Equals(other.Name);
            }

            public override int GetHashCode()
            {
                int IdHashCode = Id.GetHashCode();
                int NameHashCode = Name.GetHashCode();

                return IdHashCode ^ NameHashCode;
            }
        }

        //This is used when same or different object need to compare.
        public class Teacher
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class TeacherCompare : IEqualityComparer<Teacher>
        {
            public bool Equals(Teacher x, Teacher y)
            {
                if (object.ReferenceEquals(x, y))
                {
                    return true;
                }

                if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null))
                {
                    return false;
                }

                return x.Id == y.Id && x.Name == y.Name;
            }

            public int GetHashCode([DisallowNull] Teacher obj)
            {
                if (object.ReferenceEquals(obj, null))
                {
                    return 0;
                }

                int idHashCode = obj.Id.GetHashCode();
                int nameHashCode = obj.Name.GetHashCode();

                return idHashCode ^ nameHashCode;
            }
        }
    }
}
