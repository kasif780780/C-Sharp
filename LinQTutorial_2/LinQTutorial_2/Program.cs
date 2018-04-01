using System;
using System.Linq;
using System.Collections.Generic;


namespace LinQTutorial_2
{
    class Program
    {
        //Performing Operations on Source Elements

        static void Main(string[] args)
        {
            //Data Source
            double[] reddi = { 1, 2, 3 };


            //Query

            IEnumerable<string> query = from rad in reddi select string.Format("Area={0}", (rad) * (rad) * 3.14);

            //Query Execution


            foreach(string s in query)
            {
                Console.WriteLine(s);
            }


            Console.WriteLine("Press Any Key To Exit");
            Console.ReadKey();
        }
    }
}
