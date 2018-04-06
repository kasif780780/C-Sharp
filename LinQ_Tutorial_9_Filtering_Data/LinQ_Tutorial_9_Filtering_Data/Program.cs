using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ_Tutorial_9_Filtering_Data
{
    class Program
    {
        //Filtering Data 
        static void Main(string[] args)
        {
            string[] movies = { "Megamind", "BabyBoss", "Titanic", "TubeLight", "Ironman", "Spiderman", "Batman", "Xman" };

            IEnumerable<string> Query= from movie in movies where movie.Length == 8 select movie;

            foreach(var item in Query)
            {
                Console.WriteLine(item);
               
            }
            Console.WriteLine("Press Any Key To Exit");
                
            Console.ReadKey();
        }
    }
}
