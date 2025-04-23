using Challenges.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.Helpers
{
    internal static class MakeAListFromLinkedList
    {
        public static List<int> MakeAList(SinglyLinkedListNode head)
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

        public static void PrintList(List<int> ls)
        {
            
        }
    }
}
