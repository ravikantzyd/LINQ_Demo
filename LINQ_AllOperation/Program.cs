using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ_AllOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> subjects = new List<Student>()
            {
                new Student()
                {
                    Name="Ravi",
                    Mark=373,

                    MySubjects=new List<Subject>
                    {
                        new Subject()
                        {
                            SubjectName="Myanmar",
                            SubjectMark=46
                        },
                        new Subject()
                        {
                            SubjectName="English",
                            SubjectMark=75
                        },
                        new Subject()
                        {
                            SubjectName="Math",
                            SubjectMark=89
                        }
                    }
                },
                new Student()
                {
                    Name="Krishna",
                    Mark=320,

                    MySubjects=new List<Subject>
                    {
                        new Subject()
                        {
                            SubjectName="Myanmar",
                            SubjectMark=58
                        },
                        new Subject()
                        {
                            SubjectName="English",
                            SubjectMark=67
                        },
                        new Subject()
                        {
                            SubjectName="Math",
                            SubjectMark=90
                        }
                    }
                },
                new Student()
                {
                    Name="Shashi",
                    Mark=290,

                    MySubjects=new List<Subject>
                    {
                        new Subject()
                        {
                            SubjectName="Myanmar",
                            SubjectMark=51
                        },
                        new Subject()
                        {
                            SubjectName="English",
                            SubjectMark=78
                        },
                        new Subject()
                        {
                            SubjectName="Math",
                            SubjectMark=77
                        }
                    }
                }
            };

            var datasource = subjects.All(s => s.Mark > 300);

            Console.WriteLine("Just test for All Operation ......");

            Console.WriteLine(datasource);

            var datasource1 = subjects.Where(sub => sub.MySubjects.All(s=>s.SubjectMark>50)).ToList();

            foreach (var item in datasource1)
            {
                Console.WriteLine("Name : " + item.Name);
            }

            Console.ReadLine();
        }
    }
}
