using System;
using System.Collections.Generic;
using System.Text;

namespace WordBreak
{
    public class Solution
    {
        //Given a string s and a dictionary of strings wordDict, return true if s can be segmented into a space-separated sequence of one or more dictionary words.

        //Constrains
        //1 <= s.length <= 300
        //1 <= wordDict.length <= 1000
        //1 <= wordDict[i].length <= 20
        //s and wordDict[i] consit of  only lowercase

        public bool WordBreak(string s, IList<string> wordDict)
        {
            HashSet<string> wordDictAsHashSet = new HashSet<string>();

            for (int i = 0; i < wordDict.Count; i++)
            {
                wordDictAsHashSet.Add(wordDict[i]);
            }
            return WordBreakAsHashSet(s, wordDictAsHashSet);
        }

        public bool WordBreakAsHashSet(string s, HashSet<string> wordDict)
        {
            if (s.Length == 0) return true;

            for (int i = s.Length; i > 0; i--)
            {
                string substring = String.Empty;

                for (int j = i; j <= s.Length; j++)
                {
                    substring += s[j - 1];
                }

                if (wordDict.Contains(substring))
                {
                    if (!WordBreakAsHashSet(s.Remove(s.Length - substring.Length, substring.Length), wordDict))
                        wordDict.Remove(substring);
                    else
                        return true;

                }
            }

            return false;
        }
    }
    
}
