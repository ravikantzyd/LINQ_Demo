using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ_ElementOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> datasource = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            var ms = datasource.ElementAt(3);

            var ms1 = datasource.ElementAtOrDefault(3);

            var ms2 = datasource.First();

            var ms3 = datasource.FirstOrDefault();

            var ms4 = datasource.Last();

            var ms5 = datasource.LastOrDefault();

            Console.ReadLine();
        }
    }
}
