using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using RotateArray;
using Xunit.Sdk;

namespace LeetcodeProblemsTests.Arrays
{
    public class RotateArrayTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new int[] { 5, 6, 7, 1, 2, 3, 4 })]
        [InlineData(new int[] { -1, -100, 3, 99 },2, new int [] { 3, 99, -1, -100 })]
        [InlineData(new int[] {1,2,3,4 },2, new int[] {3,4,1,2 })]
        public void TestSolution(int[] nums, int k, int[] expected)
        {
            Solution solution = new Solution();

            solution.Rotate(nums, k);

            Assert.Equal(expected, nums);
        }
    }
}
