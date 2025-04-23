using Challenges.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.LinkedListChallenges
{
    internal class LinkedListsRemovingDupes
    {
        static void PrintSinglyLinkedList(SinglyLinkedListNode node)
        {
            while (node != null)
            {
                Console.WriteLine(node.data);

                node = node.next;
            }
        }

        static SinglyLinkedListNode removeDuplicates(SinglyLinkedListNode llist, int prev = 0)
        {
            if (llist?.data == null)
                return new SinglyLinkedListNode(0);

            if (llist?.next != null)
            {

                //pop the dupe as you go by making the next skipping to the next one.
                if (prev == llist.data && llist.next != null)
                {
                    llist.data = llist.next.data;
                }


                if (llist.data == llist.next.data)
                {
                    llist.next = llist?.next?.next ?? null;
                }

                removeDuplicates(llist.next, llist.data);
            }

            return llist;
        }

        internal static void Run(int t, int n, params int[] ints)
        {
            for (int tItr = 0; tItr < t; tItr++)
            {
                SinglyLinkedList llist = new SinglyLinkedList();


                for (int i = 0; i < n; i++)
                {
                    llist.InsertNode(ints[i]);
                }

                SinglyLinkedListNode llist1 = removeDuplicates(llist.head);

                PrintSinglyLinkedList(llist1);
            }
        }
    }
}
