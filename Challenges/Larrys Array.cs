using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    internal class Larrys_Array
    {
        public static string LarrysArray(List<int> list)
        {
            var cnt = list.Count;
            var result = "No";
            
            for (int i = 0; i < cnt-3; i++)
            {
                if (i == 0 && list[0] != 1)
                {
                    list = RotateList(list);
                    if (CheckThree(list))
                    {
                        result = "Yes";
                        continue;
                    }
                    
                    list = RotateList(list);
                    if (CheckThree(list))
                    {
                        result = "Yes";
                        continue;
                    }
                    else
                    {
                        result = "No";
                    }
                        
                }
                else
                {
                    list = list.Skip(1).ToList();

                    if (CheckThree(list))
                    {
                        result = "Yes";
                        continue;
                    }
                    else
                    {
                        list = RotateList(list);
                        if (CheckThree(list))
                        {

                            result = "Yes";
                            continue;
                        }

                        list = RotateList(list);
                        if (CheckThree(list))
                        {
                            result = "Yes";
                            continue;
                        }
                        else
                        {
                            result = "No";
                        }
                    }
                }
            }

            return result;
        }

        public static List<int> RotateList(List<int> list) => new List<int> { list[1], list[2], list[0] }.Concat(list.Skip(3)).ToList();
        public static bool CheckThree(List<int> list) => list[0] + 1 == list[1] && list[1] +1 == list[2];

        public static void Run(string[] args)
        {
            var inputs = new List<List<int>>
            {
                //new List<int>{3, 1, 2},
                //new List<int>{1, 3, 4, 2},
                new List<int>{1, 2, 3, 5, 4}
            };

            for (int i = 0; i < inputs.Count; i++)
            {
                string result = LarrysArray(inputs[i]);
                Console.WriteLine(result);
            }

        }
    }
}
