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

        public void InsertAfter(Node prev_node, int data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("the given previous Node" + "cannot be null");
                return;
            }
            Node newnode = new Node(data);
            newnode.next = prev_node.next;
            prev_node.next = newnode;
            Console.WriteLine("{0} is inserted into linkedlist", newnode.data);
        }

        public int search(int value)
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("Node is present");
                    return value;
                }
                temp = temp.next;
            }
            Console.WriteLine("\n{0} is not present", value);
            return 0;
        }
        public void DeleteBetween(int data)
        {
            Node temp = head, prev = null;
            if(temp!=null && temp.data == data)
            {
                head = temp.next;
                return;
            }
            while(temp!=null && temp.data!=data)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null)
                return;
            prev.next = temp.next;
            Console.WriteLine("{0} is deleted from linkedlist",data);
        }
        public void Display()
        {
            Console.WriteLine("Displaying Nodes");
            Node temp = this.head;
            if (temp == null)
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
        public int Getsize()
        {
            Node temp = this.head;
            int size = 0;
            while(temp!=null)
            {
                size++;
                temp = temp.next;
            }
            Console.WriteLine("Thie size of linkedList is {0}", size);
            return size;
        }
    }
}
