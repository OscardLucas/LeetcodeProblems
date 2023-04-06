using System;
using System.Collections.Generic;
using System.Text;
using UniquePaths;
using Xunit;

namespace LeetcodeProblemsTests.Arrays
{
    public class UniquePathsTest
    {
        [Theory]
        [InlineData(3,2,3)]
        [InlineData(3,7,28)]
        public void TestSolution(int m, int n, int expected)
        {
            Solution solution = new Solution();

            int actual = solution.UniquePaths(m, n);
            Assert.Equal(expected, actual);
        }
    }
}
