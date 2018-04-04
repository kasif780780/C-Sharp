using System;
using System.Linq;
using System.Collections.Generic;

namespace LinQTutorial_5
{
    class Program
    {
        //Standard Query Operator

        static void Main(string[] args)
        {
            string sentance = "the quik brown fox jumps over lagy dogs";

            //Split the string into individual words to create a collection
            string[] words = sentance.Split(' ');

            // Using query expression syntax
            var query = from word in words group word.ToUpper() by word.Length into gr orderby gr.Key
                        select new { Length = gr.Key, Words = gr };

            //Using Mathod Based Query syntax
            var query2 = words.GroupBy(w => w.Length, w => w.ToUpper()).Select(g => new { Length = g.Key, Words = g }).OrderBy(o => o.Length);

            foreach (var obj in query)
            {
                Console.WriteLine("Words of length {0}:", obj.Length);
                foreach 
                    (string word in obj.Words)
                    Console.WriteLine(word);
            }
            Console.ReadKey( );
        }
    }
}
