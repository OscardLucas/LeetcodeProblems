using System;
using System.Collections.Generic;
using System.Text;
using ValidPalindrome;
using Xunit;

namespace LeetcodeProblemsTests.Strings
{
    public class ValidPalindromeTest
    {
        [Theory]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData("race a car", false)]
        [InlineData(" ", true)]
        [InlineData("Anita lava la tina ", true)]
        [InlineData("Anana", true)]
        public void TestSolution(string s, bool expected)
        {
            Solution solution = new Solution();

            bool actual = solution.IsPalindrome(s);
            Assert.Equal(expected, actual);
        }
    }
}
