using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    internal class SparseArrays
    {
        public static List<int> MatchingStrings(List<string> stringList, List<string> queries) =>
       queries.Select(x => stringList.Where(y => y == x).Count()).ToList();

        public static void Run(List<string> stringList, List<string> queries) 
        {
            List<int> res = MatchingStrings(stringList, queries);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
}

