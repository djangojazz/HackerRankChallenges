using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.Arrays
{
    internal class Larrys_Array
    {
        public static string LarrysArray(List<int> A)
        {
            int count = 0;
            for (int i = 0; i < A.Count - 1; i++)
            {
                for (int j = i + 1; j < A.Count; j++)
                {
                    Console.WriteLine($"{A[i]} {A[j]}");
                    if (A[i] > A[j])
                    {
                        count++;
                    }
                }
            }

            return count % 2 == 0 ? "YES" : "NO";
        }

        public static List<int> RotateList(List<int> list) => new List<int> { list[1], list[2], list[0] }.Concat(list.Skip(3)).ToList();
        public static bool CheckThree(List<int> list) => list[0] + 1 == list[1] && list[1] + 1 == list[2];

        public static (string, List<int>) RotateAndCheck(List<int> list)
        {
            var result = "No";

            for (int i = 0; i < list.Count; i++)
            {
                if (CheckThree(list))
                {
                    result = "Yes";
                    break;
                }
                else
                {
                    list = RotateList(list);
                }
            }

            return (result, list);
        }

        public static void Run()
        {
            var inputs = new List<List<int>>
            {

                new List<int>{9, 6, 8, 12, 3, 7, 1, 11, 10, 2, 5, 4},
                new List<int>{17, 21, 2, 1, 16, 9, 12, 11, 6, 18, 20, 7, 14, 8, 19, 10, 3, 4, 13, 5, 15},
                new List<int>{5, 8, 13, 3, 10, 4, 12, 1, 2, 7, 14, 6, 15, 11, 9},
                new List<int>{8, 10, 6, 11, 7, 1, 9, 12, 3, 5, 13, 4, 2},
                new List<int>{7, 9, 15, 8, 10, 16, 6, 14, 5, 13, 17, 12, 3, 11, 4, 1, 18, 2},

                /*
NO
YES
NO
YES
NO
                 */ 
            };

            for (int i = 0; i < inputs.Count; i++)
            {
                Console.WriteLine($"Base: {string.Join(",", inputs[i])}");
                var inorder = inputs[i].OrderBy(x => x).ToList();
                //Console.WriteLine($"Inorder: {string.Join(",", inorder)}");

                string result = LarrysArray(inputs[i]);
                Console.WriteLine(result);
            }

        }
    }
}
