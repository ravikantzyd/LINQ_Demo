using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[]
            {
                "Ravi Kant","Krishna Kant","Shashi Kant","Cho Cho Myint"
            };

            //This is from System.Linq.

            var datasource = names.Reverse();

            var querySyntax = (from e in names
                               select e).Reverse();

            List<string> namesList = new List<string>
            {
                "Ravi Kant","Krishna Kant","Shashi Kant","Cho Cho Myint"
            };

            //This is from Collection.Generic
            //This is reverse Original List
            namesList.Reverse();

            Console.WriteLine("Linq Reverse Result ......");

            foreach (var item in datasource)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("Collection.Generic Reverse Result ......");

            foreach (var item in namesList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
