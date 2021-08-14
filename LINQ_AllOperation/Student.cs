using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_AllOperation
{
    public class Student
    {
        public string Name { get; set; }
        public int Mark { get; set; }
        public List<Subject> MySubjects { get; set; }
    }

    public class Subject
    {
        public string SubjectName { get; set; }
        public int SubjectMark { get; set; }
    }
}
