using System;
using System.Collections.Generic;
using System.Text;
using TwoSum;
using Xunit;

namespace LeetcodeProblemsTests.Arrays
{
    public class TwoSumTest
    {
        [Theory]
        [InlineData(new int[] {3, 4 , 1 , 2}, 6 ,new int[] {1, 3 })]
        [InlineData(new int[] { 2, 23, 8, 1, 3}, 25, new int[] { 0, 1 })]
        [InlineData(new int[] {1,33,4,33,2,212}, 214, new int[] { 4, 5 })]
        public void TestSolution(int [] nums, int target, int [] expected)
        {
            Solution solution = new Solution();
            int[] actual = solution.TwoSum(nums, target);
            Assert.Equal(expected, actual);
        }
    }
}
