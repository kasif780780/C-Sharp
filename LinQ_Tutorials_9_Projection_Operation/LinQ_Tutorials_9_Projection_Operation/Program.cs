using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ_Tutorials_9_Projection_Operation
{
    class Program
    {
        //Projection Operation
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "an", "apple", "a", "day" };
            var query = from word in words select word.Substring(0, 1);
            foreach(string item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
