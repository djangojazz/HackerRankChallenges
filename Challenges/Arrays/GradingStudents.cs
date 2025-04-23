using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.Arrays
{
    internal class GradingStudents
    {
        internal static List<int> gradingStudents(List<int> grades) =>
            grades.Select(x =>
            {

                if (x >= 38)
                {
                    var div = x / 5;
                    var next = 5 * (div + 1);
                    var diff = next - x;
                    x = diff < 3 ? next : x;
                }

                return x;
            }).ToList();

        internal static void Run(List<int> grades)
        {
            int gradesCount = grades.Count;


            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = gradingStudents(grades);

            Console.WriteLine(string.Join("\n", result));
        }

    }
}
