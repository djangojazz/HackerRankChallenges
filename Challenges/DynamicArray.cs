using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    internal class DynamicArray
    {
        class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;

            public SinglyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
            }
        }

        class SinglyLinkedList
        {
            public SinglyLinkedListNode head;

            public SinglyLinkedList()
            {
                this.head = null;
            }

        }

        static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter textWriter)
        {
            while (node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;

                if (node != null)
                {
                    Console.WriteLine(sep);
                }
            }
        }

        static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
        {
            if (head?.data == null)
                head = new SinglyLinkedListNode(data);
            else if (head.next == null)
                head.next = new SinglyLinkedListNode(data);
            else if (head?.next != null)
                insertNodeAtTail(head.next, data);

            return head ?? new SinglyLinkedListNode(0);
        }


        public static void Run()
        {
            TextWriter textWriter = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            var listing = new List<int> { 141, 302, 164, 530, 474 };

            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = listing.Count;

            for (int i = 0; i < llistCount; i++)
            {
                SinglyLinkedListNode llist_head = insertNodeAtTail(llist.head, listing[i]);
                llist.head = llist_head;
            }

            PrintSinglyLinkedList(llist.head, "\n", textWriter);
        }
    }
}
