using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using NumberOfIslands;

namespace LeetcodeProblemsTests.Arrays
{
    public class NumberOfIslandsTest
    {
        [Fact]
        public void TestSolution()
        {
            char[][] grid = new char[][] { 
                                   new char[] { '1', '1', '1', '1', '0' },
                                   new char[] { '1', '1', '0', '1', '0' },
                                   new char[] { '1', '1', '0', '0', '0' },
                                   new char[] { '0', '0', '0', '0', '0' }};
            int expected = 1;

            int actual = new Solution().NumIslands(grid);

            Assert.Equal(expected, actual);
        }
    }
}
