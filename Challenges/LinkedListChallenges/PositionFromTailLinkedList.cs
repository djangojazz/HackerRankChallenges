using Challenges.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.LinkedListChallenges
{
    internal class PositionFromTailLinkedList
    {
        static int getNode(SinglyLinkedListNode llist, int positionFromTail)
        {
            var ls = MakeAList(llist);
            var rev = ls.Reverse<int>().ToList();

            return rev[positionFromTail];
        }

        static List<int> MakeAList(SinglyLinkedListNode head)
        {
            var list = new List<int>();
            SinglyLinkedListNode current = head;

            while (current != null)
            {
                list.Add(current.data);
                current = current.next;
            }

            return list;
        }


        internal static void Run(string[] args)
        {
            var textWriter = new StringBuilder();

            //How many tests
            var part1 = Console.ReadLine();

            int tests = Convert.ToInt32(part1);

            for (int testsItr = 0; testsItr < tests; testsItr++)
            {
                SinglyLinkedList llist = new SinglyLinkedList();

                //next line is how many items to count next.
                int llistCount = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llistCount; i++)
                {
                    int llistItem = Convert.ToInt32(Console.ReadLine());
                    llist.InsertNode(llistItem);
                }

                int position = Convert.ToInt32(Console.ReadLine());

                int result = getNode(llist.head, position);

                textWriter.AppendLine(result.ToString());
            }

            Console.WriteLine(textWriter.ToString());
        }

    }
}
