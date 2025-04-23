using Challenges.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.LinkedListChallenges
{
    internal static class Linked_Lists
    {
        static void printLinkedList(SinglyLinkedListNode head)
        {
            if (head != null)
            {
                Console.WriteLine(head.data);
                if (head.next != null)
                {
                    printLinkedList(head.next);
                }
            }
        }

        static void Run(string[] args)
        {
            var llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                llist.InsertNode(llistItem);
            }

            printLinkedList(llist.head);
        }

    }
}
