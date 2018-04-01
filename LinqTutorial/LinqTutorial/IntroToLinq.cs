using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqTutorial
{
    class IntroToLinq
    {
        static void Main()
        {
            //The Three Parts Of LINQ Query
            //1.Data Source
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            //2.Query Creation
            var numQuery = from num in numbers where (num % 2) == 0 select num;



            //3.Query Execution
            foreach(var sys in numQuery)
            {
                Console.WriteLine(sys);
            }
            Console.ReadKey();
        }
    }
}
