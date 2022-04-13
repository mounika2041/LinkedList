using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Data Structure of linkedList");

            DataStructureLinkedList linkedList = new DataStructureLinkedList();
            linkedList.AddLast(56);
            linkedList.AddLast(30);
            linkedList.AddLast(70);
            linkedList.Display();
            Console.WriteLine("{0} is found in linkedList", linkedList.search((30)));
            linkedList.InsertAfter(linkedList.head.next, 40);
            linkedList.Display();
            Console.ReadLine();
        }
    }
}
