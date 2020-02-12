using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems_App
{
    class LQProblem4
    {
        //public List<string> testString = new List<string>() { "william" };
        public string testString =  "william";
        public string newString;
        public int count;
        public void Output()
        {
            stringSeperate();
        }

        public void stringSeperate()
        {


            newString = String.Concat(testString.OrderBy(c => c));
            var charCount = newString.GroupBy(c => c).Select(g => new { Char = g.Key, Count = g.Count() });

            foreach (var c in charCount)
            {
                Console.WriteLine($"{c.Char} = {c.Count}");  
            }
            Console.ReadLine();
        }
    }
}
