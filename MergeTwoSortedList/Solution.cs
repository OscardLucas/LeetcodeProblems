using System;
using System.Collections.Generic;
using System.Text;

namespace MergeTwoSortedList
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
        // 40min
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            ListNode result = new ListNode();

            if(list1.val <= list2.val)
            {
                result.val = list1.val;
                result.next = MergeTwoLists(list1.next, list2);
            }
            else
            {
                result.val = list2.val;
                result.next = MergeTwoLists(list1, list2.next);
            }

            return result;
        }

        public ListNode MergeTwoListsNonRecursive(ListNode list1, ListNode list2)
        {
            ListNode head = new ListNode();
            ListNode temp = head;

            while(list1 != null && list2 != null)
            {
                if(list1.val <= list2.val)
                {
                    temp.next = new ListNode(list1.val);
                    list1 = list1.next;

                }
                else
                {
                    temp.next = new ListNode(list2.val);
                    list2 = list2.next;
                }

                temp = temp.next;
            }

            temp.next = list1 ?? list2 ?? null;

            return head.next;


        }


    }
}
