using System;
using System.Collections.Generic;
using System.Linq;

namespace LinkP7
{
   //TakeWhile and SkipWhile link Operator

    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 3, 5, 2, 234, 4,1 };
            var takewhilesmall = number.TakeWhile(n => n <100);
            Console.WriteLine("TakeWhile Result");
            Console.WriteLine("==================================");
            foreach(int nm in takewhilesmall)

            {
                Console.WriteLine(nm);
                Console.ReadLine();
            }
            int[] number1 = { 3, 5, 2, 234, 4, 1 };
            var skipwhilesmall = number1.SkipWhile(n => n < 100);
            Console.WriteLine("TakeWhile Result");
            Console.WriteLine("==================================");


            foreach (int nm1 in skipwhilesmall)
            {
                Console.WriteLine(nm1);
                Console.ReadLine();
            }
        }
    }
}
