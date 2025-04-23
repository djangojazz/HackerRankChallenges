using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.Arrays
{
    internal class ArrayManipulation
    {
        internal static long arrayManipulation(int n, List<List<int>> queries)
        {
            //Create a list of n elements
            var list = new List<int>(new int[n]);

            //Iteration of each set
            for (int i = 0; i < queries.Count; i++)
            {
                var (a, b, k) = (queries[i][0], queries[i][1], queries[i][2]);

                //Iteration of each value in set
                for (int j = 1; j <= n; j++)
                {
                    //If the value is in the range of a and b, add k to it
                    if (j >= a && j <= b)
                        list[j - 1] += k;  //Update the list at the associated index
                }

            }

            return list.OrderByDescending(x => x).FirstOrDefault();
        }

        internal static string WriteLineOfNArray(IEnumerable<int> list) => string.Join(", ", list);

        internal static void Run(int n, List<List<int>> queries)
        {
            long result = arrayManipulation(n, queries);

            Console.WriteLine(result);
        }
    }
}
