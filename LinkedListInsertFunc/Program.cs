using System;

namespace LinkedListInsertFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = null;
            Console.Write("Enter how many numbers you want to insert: ");
            int T = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Numbers to be inserted: ");

            while (T-- > 0)
            {                
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
            Console.Read();

        }

        public static Node insert(Node head, int data)
        {
            Node newNode = new Node(data);
            Node current = head;

            if (head != null)
            {
                current.next = insert(head.next, data);
            }
            else
            {
                head = newNode;
            }

            return head;
        }

        public static void display(Node head)
        {
            Node start = head;
            Console.WriteLine("Linked list elements: ");
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

    }
}
