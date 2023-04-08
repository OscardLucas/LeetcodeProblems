using System;
using System.Collections.Generic;
using System.Text;
using BinarySearch;
using Xunit;

namespace LeetcodeProblemsTests.Arrays
{
    public class BinarySearchTest
    {
        [Theory]
        [InlineData(new int[] { -1, 0, 3, 5, 9, 12 }, 9, 4)]
        [InlineData(new int[] { -1, 0, 3, 5, 9, 12 }, 2, -1)]
        [InlineData(new int[] {-1, 0, 5 }, 5, 2)]
        [InlineData(new int[] { -1, 0, 5 }, -1, 0)]
        public void TestSolution(int [] nums, int target, int expected)
        {
            Solution solution = new Solution();

            int actual = solution.Search(nums, target);
            Assert.Equal(expected, actual);
        }
    }
}
