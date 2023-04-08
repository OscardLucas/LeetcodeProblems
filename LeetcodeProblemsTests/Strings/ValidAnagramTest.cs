using System;
using System.Collections.Generic;
using System.Text;
using ValidAnagram;
using Xunit;

namespace LeetcodeProblemsTests.Strings
{
    public class ValidAnagramTest
    {
        [Theory]
        [InlineData("anagram", "nagaram", true)]
        [InlineData("rat", "car", false)]
        public void TestSolution(string s, string t, bool expected)
        {
            Solution solution = new Solution();
            bool actual = solution.IsAnagram(s, t);
            Assert.Equal(expected, actual);
        }

    }
}
