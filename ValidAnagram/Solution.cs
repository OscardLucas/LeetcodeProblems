using System;
using System.Collections.Generic;
using System.Text;

namespace ValidAnagram
{
    public class Solution
    {
        //11min
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            Dictionary<char, int> hash = new Dictionary<char, int>();

            for(int i = 0; i < s.Length; i++)
            {
                if(!hash.ContainsKey(s[i]))
                {
                    hash.Add(s[i], 1);
                }
                else
                {
                    hash[s[i]] += 1;
                }
            }

            for(int i = 0; i < t.Length; i++)
            {
                if (!hash.ContainsKey(t[i]))
                    return false;

                if(hash.ContainsKey(t[i]))
                {
                    if (hash[t[i]] == 1)
                    {
                        hash.Remove(t[i]);
                    }                 
                    else
                    {
                        hash[t[i]] -= 1;
                    }
                }
            }
            return hash.Count == 0;
        }
    }
}
