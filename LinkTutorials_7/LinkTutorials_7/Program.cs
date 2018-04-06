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
            string[] words1 = { "The", "Quic", "brown", "fox" ,"jump"};
            IEnumerable<string> Query = from word in words orderby word.Length select word;

            //Primary Descending
            IEnumerable<string> Query1 = from word1 in words1 orderby word1.Substring(0, 3) descending select word1;
            Console.WriteLine("==================Primary Asecending Sorting============");
            foreach(var item in Query)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==================Primary Descending Sorting============");
            foreach (var item1 in Query1)
            {
                Console.WriteLine(item1);
            }


           

            Console.ReadKey();
        }
    }
}
