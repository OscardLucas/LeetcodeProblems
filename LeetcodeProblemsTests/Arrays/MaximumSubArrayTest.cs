using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using MaximumSubArray;

namespace LeetcodeProblemsTests.Arrays
{
    public class MaximumSubArrayTest
    {
        [Theory]
        [InlineData(new int[] {-2, 1, -3, 4, -1, 2, 1, -5, 4  }, 6)]
        [InlineData(new int[] {1 }, 1)]
        [InlineData(new int[] {5, 4, -1, 7, 8}, 23)]
        [InlineData(new int[] { -2, 1 }, 1)]
        [InlineData(new int[] { -1, -2 }, -1)]
        [InlineData(new int[] { -2, -1 }, -1)]
        [InlineData(new int[] { -3, -2, 0, -1 }, 0)]
        public void TestSolution(int [] input, int expected)
        {
            Solution solution = new Solution();

            int actual = solution.MaxSubArray(input);

            Assert.Equal(expected, actual);
        }
    }
}
