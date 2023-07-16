using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            MyBST bst = new MyBST();

            bst.Insert(9);
            bst.Insert(4);
            bst.Insert(6);
            bst.Insert(20);
            bst.Insert(170);
            bst.Insert(15);
            bst.Insert(1);
            bst.Remove(20);
            Node lookup = bst.LookUp(20);
            Console.WriteLine();

                    
        }
    }
}
