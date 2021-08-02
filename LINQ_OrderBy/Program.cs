using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ_OrderBy
{
    class Program
    {
        // oderby is sorting data to ascending only.
        static void Main(string[] args)
        {
            List<int> datasourceINT = new List<int>()
            {
                19,2,10,3,55,79,23
            };

            var methodSyntax1 = datasourceINT.OrderBy(num => num).ToList();

            var querySyntax1 = (from num in datasourceINT
                               orderby num
                               select num).ToList();

            // We should add where clause before orderby
            var methodSyntax2 = datasourceINT.Where(num => num > 10).OrderBy(num => num).ToList();

            var querySyntax2 = from num in datasourceINT
                               where num > 10
                               orderby num
                               select num;

            foreach (var item in querySyntax2)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
