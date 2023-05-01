using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ClimbingStairs;

namespace LeetcodeProblemsTests.Other
{
    public class ClimbingStairsTest
    {
        [Theory]
        [InlineData(2,2)]
        [InlineData(3, 3)]
        [InlineData(4,5)]
        [InlineData(5,8)]
        public void TestSolution(int n, int expected)
        {
            Solution solution = new Solution();

            int actual = solution.ClimbStairs(n);
            Assert.Equal(expected, actual);
        }
    }

}
