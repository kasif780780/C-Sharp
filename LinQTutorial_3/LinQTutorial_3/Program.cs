using System;
using System.Collections.Generic;
using System.Linq;


namespace LinQTutorial_3
{
    class Program
    {
        //Standard Query Operator Extension Methods
        static void Main(string[] args)
        {
            //Data Source
            int[] numbers = { 5, 10, 8, 3, 6, 12 };


            //Query Santax

            IEnumerable<int> numQuery1 = from num1 in numbers where num1 % 2 == 0 orderby num1 select num1;

            //Method Santax


            IEnumerable<int> numQuery2 = numbers.Where(num => num % 2 == 0).OrderBy(n => n);

            foreach (int i in numQuery1)
            {
                Console.Write(i +" ");
            }
            Console.WriteLine(System.Environment.NewLine);

            foreach (int i in numQuery2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine(System.Environment.NewLine);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
}
}
