using System;
using System.Collections.Generic;
using System.Text;
using FloodFill;
using Xunit;

namespace LeetcodeProblemsTests.Arrays
{
    public class FloodFillTest
    {
        public static IEnumerable<object[]> inputs =>
           new List<object[]>
           {
                new object[] { 
                    new int[][] { new int[] {1,1,1 }, 
                                  new int[] {1,1,0 }, 
                                  new int[] {1, 0, 1} }, 1,1,2,
                    new int[][] {new int[] {2,2,2 },
                                new int[] {2,2,0 },
                                new int[] {2, 0, 1} } }
           };

        [Theory]
        [MemberData(nameof(inputs))]
        public void TestSolution(int [][]image, int sr, int sc, int color, int [][] expected)
        {
            Solution solution = new Solution();

            int[][] actual = solution.FloodFill(image, sr, sc, color);
            Assert.Equal(expected, actual);
        }
    }
}
