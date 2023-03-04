using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ContainerWithMostWater;

namespace LeetcodeProblemsTests.Arrays
{
    public class ContainerWithMostWaterTest
    {
        [Theory]
        [InlineData(new int[] {1, 3, 2, 5, 25, 24, 5}, 24)]
        [InlineData(new int[] {2, 3, 4, 5, 18, 17, 6}, 17)]
        [InlineData(new int[] { 1, 1 }, 1)]
        [InlineData(new int[] { 4, 3, 2, 1, 4 }, 16)]
        public void TestSolution(int [] input, int expected)
        {
            Solution solution = new Solution();

            int actual = solution.MaxArea(input);

            Assert.Equal(expected, actual);

        }
    }
}
