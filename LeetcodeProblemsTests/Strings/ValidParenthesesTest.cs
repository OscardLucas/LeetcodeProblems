using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ValidParentheses;

namespace LeetcodeProblemsTests.Strings
{
    public class ValidParenthesesTest
    {
        [Theory]
        [InlineData("()", true)]
        [InlineData("([])", true)]
        [InlineData("([{}])", true)]
        [InlineData("(]", false)]
        [InlineData("()[]{}", true)]
        [InlineData("()[]{]", false)]
        public void TestSolution(string s, bool expected)
        {
            Solution solution = new Solution();

            bool actual = solution.IsValid(s);
            Assert.Equal(expected, actual);
        }
    }
}
