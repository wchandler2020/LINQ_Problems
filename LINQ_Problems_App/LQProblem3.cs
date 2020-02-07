using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems_App
{
    class LQProblem3
    {
        public List<string> gradeList = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
        public List<double> newStudentGradeList = new List<double>();
        public void Output()
        {
            findAverageGrade();
        }
        public void findAverageGrade()
        {
            for (int i = 0; i < gradeList.Count; i++)
            {
                var newGrade = gradeList[i].Split(',')
                                           .Select(Int32.Parse)
                                           .ToList();
                newGrade.Remove(newGrade.Min());
                newStudentGradeList.Add(newGrade.Average());
                Console.WriteLine(newGrade.Average());
            }
            Console.ReadLine();               
        }
    }
}
