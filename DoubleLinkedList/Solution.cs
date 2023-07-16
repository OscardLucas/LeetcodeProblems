using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleLinkedList
{
    public class Solution
    {
        public class Node
        {
            public Node next;
            public Node prev;
            public int val;

            public Node(int val, Node next = null, Node prev = null)
            {
                this.val = val;
                this.next = next;
                this.prev = prev;
            }
        }

        public class MyLinkedList
        {
            private Node tail = null;
            private Node head = null;
            private int length = 0;

            public MyLinkedList()
            {

            }

            public int Get(int index)
            {
                int i;
                Node node = null;

                if (HeadIsShortest(index))
                {
                    i = 0;
                    node = head;

                    while (i < index)
                    {
                        node = node.next;
                        i++;
                    }

                }

                else
                {
                    i = length - 1;
                    node = tail;

                    while (i >= 0)
                    {
                        node = node.prev;
                        i--;
                    }
                }

                return node.val;

            }

            public void AddAtHead(int val)
            {
                if (head == null)
                {
                    head = new Node(val);
                    tail = head;
                }
                else
                {
                    Node node = new Node(val);
                    head.prev = node;
                    node.next = head;
                    head = node;
                }
                length++;
            }

            public void AddAtTail(int val)
            {
                if (head == null)
                {
                    AddAtHead(val);
                }
                else
                {
                    Node node = new Node(val);
                    tail.next = node;
                    node.prev = tail;
                    tail = node;
                    length++;
                }
            }

            public void AddAtIndex(int index, int val)
            {
                if (index == 0)
                {
                    AddAtHead(val);
                }
                else if (index == length)
                {
                    AddAtTail(val);
                }
                else
                {
                    Node node = null;
                    Node newNode = new Node(val);
                    int i;

                    if (HeadIsShortest(index))
                    {
                        node = head;
                        i = 0;
                        while (i < index)
                        {
                            node = node.next;
                            i++;
                        }
                    }
                    else
                    {
                        node = tail;
                        i = length - 1;
                        while (i > index)
                        {
                            node = node.prev;
                            i--;
                        }
                    }

                    Node temp = node.prev;
                    temp.next = newNode;
                    newNode.prev = temp;
                    newNode.next = node;
                    node.prev = newNode;
                    length++;
                }
            }

            public void DeleteAtIndex(int index)
            {
                if (index == 0)
                {
                    head.next.prev = null;
                    head = head.next;
                }
                else if (index == length - 1)
                {
                    tail.prev.next = null;
                    tail = tail.prev;
                }
                else
                {
                    Node node = null;
                    int i;
                    if (HeadIsShortest(index))
                    {
                        node = head;
                        i = 0;
                        while (i < index)
                        {
                            node = head.next;
                            i++;
                        }
                    }
                    else
                    {
                        node = tail;
                        i = length - 1;
                        while (i >= 0)
                        {
                            node = node.prev;
                            i--;
                        }
                    }
                    Node temp = node.prev;
                    temp.next = node.next;
                    temp.next.prev = temp;
                }


                length--;
            }

            private bool HeadIsShortest(int index)
            {
                return length - 1 - index >= index - 0;
            }
        }
    }
}
