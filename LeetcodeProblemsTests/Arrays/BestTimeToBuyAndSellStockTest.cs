using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BestTimeToBuyAndSellStock;

namespace LeetcodeProblemsTests.Arrays
{
    public class BestTimeToBuyAndSellStockTest
    {
        [Theory]
        [InlineData(new int[] {6 ,5, 4, 3 }, 0)]
        [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
        public void TestSolution(int [] prices, int expected)
        {
            Solution solution = new Solution();

            int actual = solution.MaxProfit(prices);
            Assert.Equal(expected, actual);
        }
    }
}
