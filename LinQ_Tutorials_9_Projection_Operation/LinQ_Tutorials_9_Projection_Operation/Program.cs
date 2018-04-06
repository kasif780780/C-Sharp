using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ_Tutorials_9_Projection_Operation
{
    class Program
    {
        //Projection Operation
        //Select Vs SelectMany
        static void Main(string[] args)
        {
            List<Bouquet> bouquet = new List<Bouquet>()
            {
                new Bouquet{Flowers=new List<string>{"SunFlower","Daisy","Daffodil","larkspur"}},
                new Bouquet{Flowers=new List<string>{ "tulip", "rose", "orchid", "larkspur"}},
                new Bouquet{Flowers=new List<string>{ "gladiolis", "lilac", "snapdragon", "aster","protea"}},
                new Bouquet{Flowers=new List<string>{ "larkspur", "lily", "iris", "dahlia"}}

            };
            // *********** Select ***********       
            IEnumerable<List<string>> query1 = bouquet.Select(bq => bq.Flowers);
            // ********* SelectMany *********   
            IEnumerable<string> query2 = bouquet.SelectMany(bq => bq.Flowers);  
            Console.WriteLine("Results by using Select():");
            // Note the extra foreach loop here.    
            foreach (IEnumerable<String> collection in query1)
                foreach (string item in collection)
                    Console.WriteLine(item);  
            Console.WriteLine("\nResults by using SelectMany():");
            foreach (string item in query2)
                Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
