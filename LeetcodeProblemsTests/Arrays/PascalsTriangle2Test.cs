using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using PascalsTriangle2;

namespace LeetcodeProblemsTests.Arrays
{
    public class PascalsTriangle2Test
    {
        [Theory]
        [InlineData(3, new int[] { 1, 3, 3, 1 })]
        [InlineData(0, new int[] {1})]
        [InlineData(1, new int[] {1,1 })]
        [InlineData(8,new int[] {1,8,28,56,70,56,28,8,1 })]
        public void TestSolution(int index, int[] expected)
        {
            Solution solution = new Solution();

            var actual = solution.GetRow(index);
            Assert.Equal(expected, actual); 

        }
    }
}
