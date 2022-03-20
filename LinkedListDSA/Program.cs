using System;

namespace LinkedListDSA
{

    class Program
    {
        int length(Node head)
        {
            if (head == null)
            {
                return 0;
            }
            return 1 + length(head.next);
        }
        Node Middle(Node head)
        {
            Node slow = head;
            Node fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }
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

        Node DeleteNode(Node head, int index)
        {
            Node temp = head;
            if (index < 0)
                return head;
            if (index == 0)
            {
                var node = temp.next;
                temp.next = null;
                return node;
            }
            int counter = 0;
            // 100 200 300 400
            while (counter < index - 1 && temp != null)
            {
                temp = temp.next;
                counter++;
            }
            if (temp != null)
            {
                var removeNode = temp.next;
                temp.next = removeNode.next;
            }
            return head;
        }
        Node DeleteNodeRecursive(Node head, int index)
        {
            if (head == null)
                return head;
            if (index == 0)
            {
                head = head.next;
                return head;
            }
            Node node = DeleteNodeRecursive(head.next, index - 1);
            head.next = node;
            return head;
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
        Node InsertNodeRecursive(Node head, int data, int index)
        {
            Node newNode = new Node(data);
            if (head == null)
                return head;
            if (index == 0)
            {
                newNode.next = head;
                head = newNode;
                return head;
            }
            Node node = InsertNodeRecursive(head.next, data, index - 1);
            head.next = node;
            return head;
        }
        Node ReverseRecursion(Node head)
        {
            if (head.next == null)
                return head;

            Node x = ReverseRecursion(head.next);
            head.next.next = head;
            head.next = null;
            return x;
        }
        Node ReverseInterative(Node head)
        {
            if (head == null)
                return null;
            Node p = null;
            Node c = head;
            Node n = head.next;

            while (c != null)
            {
                c.next = p;
                p = c;
                c = n;
                if (n != null)
                    n = n.next;
            }
            return p;
        }

        Node MergeRecursive(Node l1, Node l2)
        {
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;
            if (l1.data < l2.data)
            {
                l1.next = MergeRecursive(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = MergeRecursive(l1, l2.next);
                return l2;
            }

        }

        Node RemoveDuplicatesRecursion(Node head)
        {
            if (head == null || head.next == null)
                return head;
            var nodes = RemoveDuplicatesRecursion(head.next);
            if (head.data == nodes.data)
            {
                return nodes;
            }
            else
            {
                head.next = nodes;
                return head;
            }
        }
        Node RemoveDuplicates(Node head)
        {
            if (head == null || head.next == null)
                return head;
            Node temp = head;
            while (temp != null && temp.next != null)
            {
                if (temp.data == temp.next.data)
                {
                    temp.next = temp.next.next;
                }
                else {
                    temp = temp.next;
                }
            }
            return head;
        }

        Node Merge(Node list1, Node list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;
            Node answer = new Node(0);
            Node tail = answer;
            while (list1 != null && list2 != null)
            {
                if (list1.data < list2.data)
                {
                    tail.next = list1;
                    tail = list1;
                    list1 = list1.next;
                }
                else
                {
                    tail.next = list2;
                    tail = list2;
                    list2 = list2.next;
                }
            }
            if (list1 == null) tail.next = list2;
            if (list2 == null) tail.next = list1;
            return answer.next;

        }

        static void Main(string[] args)
        {

            Console.WriteLine("Hello Linked List!");
            Node list1;

            var n1 = new Node(1);
            list1 = n1;
            var n2 = new Node(2);
            n1.next = n2;
            var n3 = new Node(2);
            n2.next = n3;
            var program = new Program();
            var n = program.RemoveDuplicates(list1);
            program.PrintLinkedList(n);


        }
    }
}
