using System;
using System.Linq;
using System.Collections.Generic;

namespace LinQTutorial_8_Set_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Asif", "Asif", " Tom", "Jaery", "Vin", };
          //  string[] names1 = { "Asif", "Asif", " Tom", "Jaery", "Vin", };

            //Distinct Sorting
            IEnumerable<string> query = from name in names.Distinct() orderby name.Length select name;
            foreach(var item in query)
            {

                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
