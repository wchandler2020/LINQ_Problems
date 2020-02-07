using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems_App
{
    class LQProblem2
    {
        List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };

        public void Output()
        {
            findDuplicateString();
        }
        public void findDuplicateString()
        {
            var result = names.Distinct();
            foreach(string name in result)
            {
                Console.WriteLine($"Names: {name}");
            }
            Console.ReadLine();
        }
    }
}

