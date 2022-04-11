using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class DataStructureLinkedList
    {
        public Node head;
        /// <summary>
        /// UC2
        /// </summary>
        /// <param name="new data"></param>
        public void AddFirst(int new_data)
        {
            Node new_Node = new Node(new_data);
            new_Node.next = this.head;
            this.head = new_Node;
            Console.WriteLine("{0} Node is inserted into linkedList", new_Node.data);
        }
        public void Display()
        {
            Console.WriteLine("Displaying Nodes");
            Node temp = this.head;
            if(temp==null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;
            }
        }
    }
}
