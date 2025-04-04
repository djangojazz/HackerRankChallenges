namespace Challenges
{
    internal class InsertDataAtHead
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

        static SinglyLinkedListNode insertNodeAtHead(SinglyLinkedListNode llist, int data, SinglyLinkedListNode prev = null)
        {
            var node = new SinglyLinkedListNode(data);

            if (prev != null) //Already have a node incoming
            {
                node.next = llist; 
                prev.next = node; 
            }
            else if (llist != null) //new head
            {
                node = new SinglyLinkedListNode(data);
                node.next = llist; //link the new head to the previous head
            }

            return node ?? new SinglyLinkedListNode(0);
        }


        public static void Run()
        {
            TextWriter textWriter = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            var listing = new List<int> { 141, 302, 164, 530, 474 };

            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = listing.Count;

            for (int i = 0; i < llistCount; i++)
            {
                SinglyLinkedListNode llist_head = insertNodeAtHead(llist.head, listing[i]);
                llist.head = llist_head;
            }

            PrintSinglyLinkedList(llist.head, "\n", textWriter);
        }
    }
}
