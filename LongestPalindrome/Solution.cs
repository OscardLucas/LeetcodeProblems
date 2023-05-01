using System;
using System.Collections.Generic;
using System.Text;

namespace LongestPalindrome
{
    public class Solution
    {
        public int LongestPalindrome(string s)
        {
            Dictionary<char, int> hash = new Dictionary<char, int>();
            
            for(int i = 0; i < s.Length; i++)
            {
                if (hash.ContainsKey(s[i]))
                {
                    hash[s[i]]++;
                }                 
                else
                {
                    hash[s[i]] = 1;
                }
            }

            int length = 0;
            bool inpairTaken = false;

            foreach(char key in hash.Keys)
            {


                if(hash[key] > 1)
                {
                    if(hash[key] % 2 == 0)
                    {
                        length += hash[key];
                    }
                    else if(!inpairTaken)
                    {
                        inpairTaken = true;
                        length += hash[key];
                    }
                    else
                    {
                        length += hash[key] - 1;
                    }
                }
                else if(!inpairTaken)
                {
                    inpairTaken = true;
                    length += 1;
                }
            }

            return length;

        }
    }
}
