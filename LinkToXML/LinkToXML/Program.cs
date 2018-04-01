using System;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;

namespace LinqTutorial
{
    class LinkToXML
    {
        static void Main()
        {
            //Create The Data Source by Using a Collection Initilizer
            //The Student Class was defined

            List<Student> students = new List<Student>()
            {
                new Student {
                    First ="Svetlana",
                    Last ="Omelchenko",
                    ID =111,
                    Scores = new List<int>{97, 92, 81, 60}},
                new Student {
                    First ="Claire",
                    Last ="O’Donnell",
                    ID =112,
                    Scores = new List<int>{75, 84, 91, 39}},
                new Student {
                    First ="Sven",
                    Last ="Mortensen",
                    ID =113,
                    Scores = new List<int>{88, 94, 65, 91}},

            };

            //Create The Query

            var studentToXML = new XElement("Root", from std in students

               let x = string.Format("{0} {1},{2},{3}", std.Scores[0],std.Scores[1], std.Scores[2], std.Scores[3])



                 select new XElement("std",

                  new XElement("First", std.First),    
                  new XElement("First", std.Last),
                  new XElement("Score", x)
                                                     )
                    );

            Console.WriteLine(studentToXML);
            //Execute The Query
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

}

