using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ_Skip
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> datasource = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            List<string> names = new List<string>()
            {
                "Ravi", "Krishna", "Shashi", "Cho"
            };

            var ms = datasource.Skip(3).ToList();

            var ms1 = datasource.Where(x => x > 4).Skip(3).ToList();

            var ms2 = datasource.SkipWhile(x => x < 3).ToList();

            var ms3 = names.SkipWhile((name, index) => name.Length > index).ToList();

            Console.ReadLine();
        }
    }
}
