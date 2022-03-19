using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
