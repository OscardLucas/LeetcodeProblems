using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseLinkedList
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }


    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            
            ListNode prev = null, current = head, next = null;
            //5 3 1
            while(current !=null)
            {
                next = current.next; // 3 1 null
                current.next = prev; // null 5 3
                prev = current; // 5 3 1
                current = next; // 3 1
            }

            return prev;
        }
 

    }
}
