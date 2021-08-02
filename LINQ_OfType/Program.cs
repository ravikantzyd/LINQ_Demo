using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_OfType
{
    class Program
    {
        static void Main(string[] args)
        {
            var datasource = new List<object>() { "Adam", "Hary", "Kim", "Jhon", 1, 2, 3, 4, 5 };

            var methodSyntax = datasource.OfType<int>();

            var methodSyntax1 = datasource.OfType<string>().Where(x => x.Length > 3);

            var querySyntax = from x in datasource
                              where x is string
                              select x;

            foreach (var item in methodSyntax1)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
