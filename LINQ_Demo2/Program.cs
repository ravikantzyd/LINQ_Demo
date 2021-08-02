using System;
using System.Linq;

namespace LINQ_Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Ravi","Krishna","Shashi","Kyaw Kyaw","Htun Htun","Cho Cho Myint" };

            var data = from name in names where name.Contains('R') select name;

            Console.WriteLine("Showing name of containing R .....");
            Console.WriteLine();

            foreach(string name in data)
            {
                Console.WriteLine(name);
            }

            var data1 = from name in names where name.StartsWith("K") orderby name descending select name;

            Console.WriteLine();
            Console.WriteLine("Showing name of starting with K ....");
            Console.WriteLine();

            foreach(string name in data1)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
