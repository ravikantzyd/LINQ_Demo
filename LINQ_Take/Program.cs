using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ_Take
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> datasource = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            var ms = datasource.Take(5).ToList();

            var ms1 = datasource.Where(x => x > 3).Take(4).ToList();

            var qs = (from t in datasource
                      select t).Take(5).ToList();


            var ms2 = datasource.TakeWhile(x => x < 7).ToList();

            List<string> names = new List<string>()
            {
                "Ravi", "Krishna", "John", "Kim", "Cho"
            };

            var ms3 = names.TakeWhile((name, index) => name.Length > index).ToList();

            Console.ReadLine();
        }
    }
}
