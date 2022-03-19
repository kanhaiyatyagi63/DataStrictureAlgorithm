using System;

namespace LinkedListDSA
{

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
        }

        Node InsertNode(Node head, int data, int index)
        {
            // handling less than 0 index
            if (index < 0)
                return head;

            Node temp = head; // temp node for maintaining head
            Node newNode = new Node(70);
            var count = 0;
            // handling insert at 0;
            if (index == 0)
            {
                newNode.next = head;
                head = newNode;
                return head;
            }
            // handling index out of bound and adding condition
            while (count < index - 1 && temp != null)
            {
                temp = temp.next;
                count++;
            }
            if (temp != null)
            {
                newNode.next = temp.next;
                temp.next = newNode;
            }
            return head; // return current head
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Hello Linked List!");
            Node head;
            var n1 = new Node(1);
            head = n1;
            var n2 = new Node(2);
            n1.next = n2;
            var n3 = new Node(3);
            n2.next = n3;
            var n4 = new Node(4);
            n3.next = n4;
            var n5 = new Node(5);
            n4.next = n5;

            var header = new Program().InsertNode(head, 70, -1);
            new Program().PrintLinkedList(header);

        }
    }
}
