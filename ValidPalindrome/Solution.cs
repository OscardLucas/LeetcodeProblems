using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ValidPalindrome
{
    public class Solution
    {
        //12min
        public bool IsPalindrome(string s)
        {
            int left = 0, right = s.Length - 1;
            
            while(left < right)
            {
                if(!Char.IsLetterOrDigit(s[left]))
                {
                    left++;
                    continue;
                }

                if(!Char.IsLetterOrDigit(s[right]))
                {
                    right--;
                    continue;
                }

                if (Char.ToLower(s[left]) != Char.ToLower(s[right]))
                    return false;

                left++;
                right--;
            }

            return true;
        }

        public bool IsPalindromeRgx(string s)
        {
            string str = Regex.Replace(s.ToLower(), "[^a-z0-9]", "");
            string rev = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }

            return rev == str;
        }
    }
}
