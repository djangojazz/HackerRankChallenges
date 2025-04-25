using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.Heap
{
    internal class CookiesSweet
    {
        public static int Run(int k, List<int> A)
        {
            var count = 0;

            while (A.Count > 0 && A.Min() <= k)
            {
                if (A.Count < 2)
                    return -1;

                var first = A.Min();
                A.Remove(first);
                var second = A.Min();
                A.Remove(second);

                var newCookie = first + (second * 2);
                A.Add(newCookie);
                count++;
            }

            return count;
        }
    }
}
