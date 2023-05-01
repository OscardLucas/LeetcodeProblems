using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ReverseLinkedList;

namespace LeetcodeProblemsTests.LinkedList
{
    public class ReversLinkedListTest
    {
        public static IEnumerable<object[]> inputs =>
            new List<object[]>
            {
                new object[]
                {
                    new ListNode(5, new ListNode(3, new ListNode(1))),
                    new ListNode(1, new ListNode(3, new ListNode(5)))
                }
            };
            
         

        [Theory]
        [MemberData(nameof(inputs))]
        public void TestSolution(ListNode list, ListNode expected)
        {
            Solution solution = new Solution();
            ListNode actual = solution.ReverseList(list);
            
            while(actual != null && expected != null)
            {
                Assert.Equal(expected.val, actual.val);
                actual = actual.next;
                expected = expected.next;
            }
        }
    }
}
