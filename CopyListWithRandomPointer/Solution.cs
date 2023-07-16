using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CopyListWithRandomPointer
{
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }
    public class Solution
    {
        public Node CopyRandomList(Node head)
        {
            if (head == null) return null;

            Dictionary<Node, int> objIndex = new Dictionary<Node, int>();

            Node temp = head;
            int index = 0;
            while (temp != null)
            {
                objIndex.Add(temp, index++);
                temp = temp.next;
            }

            Dictionary<Node, int> objPointer = new Dictionary<Node, int>();

            temp = head;
            while (temp != null)
            {
                if (temp.random != null)
                {
                    objPointer.Add(temp, objIndex[temp.random]);
                }
                temp = temp.next;

            }

            Node copyHead = new Node(0);
            temp = copyHead;
            Node temp2 = head;
            Dictionary<int, Node> indexObject = new Dictionary<int, Node>();
            index = 0;
            while (temp2 != null)
            {
                temp.next = new Node(temp2.val);
                indexObject.Add(index++, temp.next);
                temp = temp.next;
                temp2 = temp2.next;

            }

            temp2 = head;
            temp = copyHead.next;
            while (temp2 != null)
            {
                if (temp2.random != null)
                {
                    var hash = temp2.random.GetHashCode();
                    if (objPointer.ContainsKey(temp2.random))
                    {
                        Console.WriteLine("");
                    }
                    else
                    {
                        var val = objPointer.ElementAt(0);
                        var hashVal = val.Key.GetHashCode();
                    }
                    temp.random = indexObject[objPointer[temp2]];
                }
                temp2 = temp2.next;
                temp = temp.next;
            }

            return copyHead.next;
        }
    }
}
