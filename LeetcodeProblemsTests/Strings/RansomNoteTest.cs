using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using RansomNote;

namespace LeetcodeProblemsTests.Strings
{
    public class RansomNoteTest
    {
        [Theory]
        [InlineData("a","b", false)]
        [InlineData("aa", "ab", false)]
        [InlineData("aa", "aab", true)]
        public void TestSolution(string ransomNote, string magazine, bool expected)
        {
            Solution solution = new Solution();
            bool actual = solution.CanConstruct(ransomNote, magazine);

            Assert.Equal(expected, actual);
        }
    }
}
