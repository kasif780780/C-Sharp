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
            //1. Create First Data Source 
            List<Student> students = new List<Student>()
            {
                   new Student {
                       First ="Svetlana",
                       Last ="Omelchenko",
                       ID =111,
                       Street ="123 Main Street",
                       City ="Seattle",
                       Scores = new List<int> {97, 92, 81, 60}},
                   new Student {First="Claire",
                       Last ="O’Donnell",
                       ID =112,
                       Street ="124 Main Street",
                       City ="Redmond",
                       Scores = new List<int> {75, 84, 91, 39}},
                    new Student {First="Sven",
                        Last ="Mortensen",
                        ID =113,
                        Street ="125 Main Street",
                        City ="Lake City",
                        Scores = new List<int> {88, 94, 65, 91}},

            };
            //2 Create Second Data Source
            List<Teacher> teachers = new List<Teacher>() {
                new Teacher {
                    First = "Ann",
                    Last = "Beebe",
                    ID = 945,
                    City = "Seattle" },
                new Teacher {
                    First = "Alex",
                    Last = "Robinson", ID = 956,
                    City = "Redmond" },
                new Teacher {
                    First = "Michiyo",
                    Last = "Sato",
                    ID = 972,
                    City = "Tacoma" }
            };

            //2.Query Creation
            //  var numQuery = from num in numbers where (num % 2) == 0 select num;


            var pepoleinSeattle = (from std in students where std.City == "Seattle" select std.Last)
                .Concat(from tech in teachers where tech.City == "Seattle" select tech.Last);
                


            //3.Query Execution
            foreach (var sys in pepoleinSeattle)
            {
                Console.WriteLine(sys);
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
