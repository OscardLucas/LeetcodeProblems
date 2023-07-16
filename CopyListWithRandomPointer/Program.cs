using System;

namespace CopyListWithRandomPointer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(7);
            node.next = new Node(13);
            node.next.random = node;
            node.next.next = new Node(11);
            node.next.next.next = new Node(10);
            node.next.next.next.random = node.next.next;
            node.next.next.next.next = new Node(1);
            node.next.next.next.next.random = node;
            node.next.next.random = node.next.next.next.next;

            Solution solution = new Solution();
            var res = solution.CopyRandomList(node);
            Console.WriteLine("Hello World!");
        }
    }
}
