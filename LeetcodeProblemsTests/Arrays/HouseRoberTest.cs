using System;
using System.Collections.Generic;
using System.Text;
using HouseRobber;
using Xunit;

namespace LeetcodeProblemsTests.Arrays
{
    public class HouseRoberTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 1}, 4)]
        [InlineData(new int[] { 2, 7, 9, 3, 1 }, 12)]
        [InlineData(new int[] { 3, 5, 2, 12 , 4 ,1 ,1 ,3 }, 21)]

        public void TestSolution(int [] nums, int expected)
        {
            Solution solution = new Solution();

            int actual = solution.Rob(nums);

            Assert.Equal(expected, actual);

        }
    }
}
