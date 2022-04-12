using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class DataStructureLinkedList
    {

        /// <summary>
        /// UC2
        /// </summary>
        /// <param name="new data"></param>
        public Node head;
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = newNode;
            }
            Console.WriteLine("{0} Node is inserted into LinkedList", newNode.data);
        }
        private Node GetLastNode()
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        public int DeleteLast()
        {
            Node temp = this.head;
            if (this.head == null)
            {
                Console.WriteLine("linked list is empty");
                return 0;
            }
            if (this.head.next == null)
            {
                int data = head.data;
                this.head = null;
                return data;
            }
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            int lastDeletedNode = temp.next.data;
            temp.next = null;
            Console.WriteLine("{0} Node is Deleted from LinkedList", lastDeletedNode);
            return lastDeletedNode;
        }
        public int search(int value)
        {
            Node temp = this.head;
            while(temp!=null)
            {
                if(temp.data==value)
                {
                    Console.WriteLine("Node is present");
                    return value;
                }
                temp = temp.next;
            }
            Console.WriteLine("\n{0} is not present", value);
            return 0;
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
