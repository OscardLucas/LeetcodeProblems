using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListCycle
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    //15min
    //Study fast and slow pointers
    public class Solution
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null) return false; 

            HashSet<ListNode> refPointer = new HashSet<ListNode>();

            refPointer.Add(head);

            while(head.next != null)
            {
                if (refPointer.Contains(head.next))
                    return true;
                else
                    refPointer.Add(head.next);

                head = head.next;
            }

            return false;
        }
    }
}
