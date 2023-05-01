using System;
using System.Collections.Generic;
using System.Text;

namespace RansomNote
{
    public class Solution
    {
        //12min
        public bool CanConstruct(string ransomNote, string magazine)
        {
            if (ransomNote.Length > magazine.Length)
                return false;

            Dictionary<char, int> letter = new Dictionary<char, int>();

            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (letter.ContainsKey(ransomNote[i]))
                {
                    letter[ransomNote[i]] += 1;
                }
                else
                {
                    letter.Add(ransomNote[i], 1);
                }
            }

            for (int i = 0; i < magazine.Length; i++)
            {
                if (letter.Count == 0) return true;

                if (letter.ContainsKey(magazine[i]))
                {
                    if (letter[magazine[i]] == 1)
                        letter.Remove(magazine[i]);
                    else
                        letter[magazine[i]] -= 1;
                }
            }

            return letter.Count == 0;
        }
    }
}
