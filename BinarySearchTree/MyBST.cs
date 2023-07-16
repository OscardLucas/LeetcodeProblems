using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class Node
    {
        public Node Left;
        public Node Right;
        public int Value;

        public Node(int value)
        {
            this.Value = value;
        }

    }
    public class MyBST
    {
        private Node Root;

        public MyBST()
        {
            Root = null;
        }
        public void Insert(int value)
        {
            if(Root == null)
            {
                Root = new Node(value);
            }
            else
            {
                Node node = Root;

                while(true)
                {
                    if(value > node.Value)
                    {
                        if(node.Right == null)
                        {
                            node.Right = new Node(value);
                            break;
                        }

                        node = node.Right;
                    }
                    else
                    {
                        if(node.Left == null)
                        {
                            node.Left = new Node(value);
                            break;
                        }

                        node = node.Left;
                    }
                }

            }
        }

        public Node LookUp(int value)
        { 
            Node node = Root;

            while(true)
            {
                if (node == null) return null;

                if(value == node.Value)
                {
                    return node;
                }
                else
                {
                    if(value > node.Value)
                    {
                        node = node.Right;
                    }
                    else
                    {
                        node = node.Left;
                    }
                }
            }
        }

        public void Remove(int value)
        {
            if (Root == null) return;


            Node current = Root;
            Node parent = null;

            while(current != null)
            {
                //Search by left
                if (value < current.Value)
                {
                    parent = current;
                    current = current.Left;
                }
                //Search by right
                else if(value > current.Value)
                {
                    parent = current;
                    current = current.Right;
                }
                //Value found
                else if(value == current.Value)
                {
                    // no leafs
                    if(current.Right == null && current.Left == null)
                    {
                        if (current.Value > parent.Value)
                            parent.Right = null;
                        else
                            parent.Left = null;
                    }

                    // No right Node
                    else if(current.Right == null)
                    {
                        if(parent == null)
                        {
                            Root = current.Left;
                        }
                        else
                        {
                            if(current.Value > parent.Value)
                            {
                                parent.Right = current.Left;
                            }
                            else if(current.Value < parent.Value)
                            {
                                parent.Left = current.Left;
                            }
                        }
                    }

                    //right node without left node
                    else if(current.Right.Left == null)
                    {
                        if(parent == null)
                        {
                            Root = Root.Right;
                        }
                        else
                        {
                            current.Right.Left = current.Left;

                            if (current.Value > parent.Value)
                            {
                                parent.Right = current.Right;
                            }
                            else if(current.Value < parent.Value)
                            {
                                parent.Left = current.Right;
                            }

                        }
                    }

                    else if(current.Right.Left != null)
                    {
                        //Find the smallest value by left side
                        Node smallest = current.Right.Left;
                        Node parentSmallest = current.Right;

                        while(smallest.Left != null)
                        {
                            parentSmallest = smallest;
                            smallest = smallest.Left;
                        }

                        parentSmallest.Left = smallest.Right;

                        smallest.Right = current.Right;
                        smallest.Left = current.Left;

                        if (parent == null)
                            Root = smallest;
                        else
                        {
                            if(current.Value > parent.Value)
                            {
                                parent.Right = smallest;
                            }
                            else
                            {
                                parent.Left = smallest;
                            }
                        }
                    }
                    return;
                }

            }
        }
    }
}
