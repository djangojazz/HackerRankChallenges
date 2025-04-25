using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.Stacks
{
    internal class EqualStacks
    {
        internal static int Run(List<int> h1, List<int> h2, List<int> h3)
        {
            var oneToTwo = CompareTwoLists(ref h1, ref h2);
            var twoToThree = CompareTwoLists(ref h2, ref h3);
            var oneToThree = CompareTwoLists(ref h1, ref h3);

            //If there is no equality recurse
            if(!(oneToTwo && twoToThree && oneToThree))
                return Run(h1, h2, h3);

            return h1.Sum();
        }

        static bool CompareTwoLists(ref List<int> a, ref List<int> b)
        {
            var sum1 = a.Sum();
            var sum2 = b.Sum();

            if (sum1 != sum2)
            {
                if (sum1 > sum2)
                    a = PopAndReturn(a);
                else
                    b = PopAndReturn(b);
            }

            return a.Sum() == b.Sum();
        }

        static List<int> PopAndReturn(List<int> l)
        {
            l.RemoveAt(0);
            return l;
        }
    }
}
