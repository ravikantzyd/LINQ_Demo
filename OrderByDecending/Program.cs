using System;
using System.Linq;
using System.Collections.Generic;

namespace OrderByDecending
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>()
            {
                "Ravi Kant",
                "Krishna Kant",
                "Shashi Kant",
                "Cho Cho Myint",
                "Kyaw Kyaw",
                "Mg Mg",
                "Ko Ko"
            };

            var methodSyntax = students.OrderByDescending(s => s);

            var querySyntax = from s in students
                              orderby s descending
                              select s;

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
