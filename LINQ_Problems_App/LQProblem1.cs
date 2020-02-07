using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems_App
{
    class LQProblem1
    {
        public List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics"};

        public void Output()
        {
            findSubString();
        }
        public void findSubString()
        {
            var newWord = words.Where(m => m.Contains("th"));
            foreach(string word in newWord)
            {
                Console.WriteLine($"test {word}");     
            }
            Console.ReadLine();
        }
    }
}
