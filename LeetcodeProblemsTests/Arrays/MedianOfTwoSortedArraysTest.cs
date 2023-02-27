using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;
using MedianOfTwoSortedArrays;

namespace LeetcodeProblemsTests.Arrays
{
    public class MedianOfTwoSortedArraysTest
    {
        [Theory]
        [InlineData(new int[] {1, 3}, new int[] {2})]
        [InlineData(new int[] {1, 2}, new int[] {3, 4 })]
        [InlineData(new int[] { 5, 10, 15 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { 2}, new int[] {3, 55, 100, 101 })]
        public void TestSolution(int[] input1, int[] input2)
        {
            Solution solution = new Solution();
            //Arrange

            int [] mergedArray = input1.Concat(input2).ToArray();
            Array.Sort(mergedArray);

            double expected = 0;

            if (mergedArray.Length % 2 == 0)
            {
                int medianIndex = mergedArray.Length / 2;
                int val1 = mergedArray[medianIndex];
                int val2 = mergedArray[medianIndex - 1];
                expected = (val1 + val2) / (double)2;
            }
            else
            {
                expected = mergedArray[(mergedArray.Length / 2)];
            }

            Assert.Equal(expected, solution.FindMedianSortedArrays(input1, input2));
        }
    }
}
