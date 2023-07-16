using System;

namespace DoubleLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Solution.MyLinkedList dlinkedList = new Solution.MyLinkedList();
            dlinkedList.AddAtHead(0);
            dlinkedList.DeleteAtIndex(0);
            //dlinkedList.AddAtTail(3);
            //dlinkedList.AddAtIndex(1, 2);
            Console.WriteLine("Hello World!");
        }
    }
}
