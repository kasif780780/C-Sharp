using System;
using System.Collections.Generic;
using System.Linq;

namespace LinkTutorials_7
{

    // Query Expression Syntax Examples 
    class Program
    {
        static void Main(string[] args)
        {
          //  Primary Ascending Sort

            string[] words = { "Asif", "Denim", "Akon", "Application" };
         IEnumerable<string> Query = from word in words orderby word.Length select word;

            foreach(var item in Query)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
