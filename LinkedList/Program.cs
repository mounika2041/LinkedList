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
            Console.WriteLine("please choose program number to execute");
            Console.WriteLine("1:linkedList");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {

                case 1:

                    DataStructureLinkedList linkedList = new DataStructureLinkedList();
                    linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(70);
                    linkedList.DeleteFirst();
                    linkedList.Display();
                    break;
                default:
                    Console.WriteLine("please choose program with in the range");
                    break;
            }
            Console.ReadLine();
        }
    }
}
