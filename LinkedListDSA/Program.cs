using System;

namespace LinkedListDSA
{
    public class Node
    {
        public int data { get; set; }
        public Node next;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }

    }
    class Program
    {
        void PrintLinkedList(Node head)
        {
            Node temp = head;
            var counter = 1;
            while (temp != null)
            {
                Console.WriteLine($"Node {counter} => {temp.data}");
                temp = temp.next;
                counter++;
            }
            while (temp != null)
            {
                Console.WriteLine($"Node {counter} => {temp.data}");
                temp = temp.next;
                counter++;
            }

        }

        static void Main(string[] args)
        {

            Console.WriteLine("Hello Linked List!");
            Node head;
            var n1 = new Node(10);
            head = n1;
            var n2 = new Node(200);
            n1.next = n2;
            var n3 = new Node(30);
            n2.next = n3;
            var n4 = new Node(40);
            n3.next = n4;
            var n5 = new Node(5);
            n4.next = n5;
            new Program().PrintLinkedList(head);

        }
    }
}
