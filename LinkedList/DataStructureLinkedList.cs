﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class DataStructureLinkedList
    {
        public Node head;
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if(head==null)
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
            while(temp.next!=null)
            {
                temp = temp.next;
            }
            return temp;
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