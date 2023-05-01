using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using MinimumSizeSubarraySum;

namespace LeetcodeProblemsTests.Arrays
{
    public class MinimumSizeSubarraySumTest
    {
        [Theory]
        [InlineData(new int[] { 2, 3, 1, 2, 4, 3 }, 7, 2)]
        [InlineData(new int[] { 1, 4, 4 }, 4, 1)]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 1, 1, 1 },11,0)]
        [InlineData(new int[] { 12, 28, 83, 4, 25, 26, 25, 2, 25, 25, 25, 12 },213,8)]
        [InlineData(new int[] {30,30,30,30,20,100,30 },130,2)]     

        public void TestSolution(int[] nums, int target, int expected)
        {
            Solution solution = new Solution();

            int actual = solution.MinSubArrayLen(target, nums);

            Assert.Equal(expected, actual);
        }
    }
}
