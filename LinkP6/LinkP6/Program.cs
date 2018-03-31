using System;
using System.Collections.Generic;
using System.Linq;

namespace LinkP6
{
    class Program
    {
        //Where returns the elements from the input sequence that satisfy the given predicate
        static void Main(string[] args)
        {
            string[] names = { "Asif", "Tom", "Jeery", "Merry", "Dick" };
            //IEnumerable<string> query = names.Where(n => n.EndsWith("y"));

            //foreach(string name in query)
            //{
            //    Console.WriteLine(name);
            //    Console.ReadLine();
            //}

            //query sentax
            IEnumerable<string> query = from n in names where n.EndsWith("y")select n;
           foreach(string n in query)
            {
                Console.WriteLine(n);
                Console.ReadLine();
            }

        }
    }
}
