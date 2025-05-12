using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.Arrays
{
    internal static class FindRepeatingPairs
    {
        internal static int Run(string[] array)
        {
            var tracking = new List<(int, int)> ();

            for(int i = 0; i < array.Length; i++)
            {
                var current = array[i];
                
                for (int j = i + 1; j < array.Length; j++)
                {
                    var next = array[j];

                    if (next.Contains(current) )
                    {
                        tracking.Add((i, j));
                    }
                }
            }

            return tracking.Count;
        }
    }
}
