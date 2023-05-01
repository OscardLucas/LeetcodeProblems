using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using LongestPalindrome;

namespace LeetcodeProblemsTests.Strings
{
    public class LongestPalindromeTest
    {
        [Theory]
        [InlineData("abccccdd", 7)]
        [InlineData("a", 1)]
        [InlineData("anitalavalatinaa",15)]
        public void TestSolutiom(string s, int expected)
        {
            Solution solution = new Solution();

            int actual = solution.LongestPalindrome(s);

            Assert.Equal(expected, actual);
        }
    }
}
