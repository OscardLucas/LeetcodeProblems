using System;
using System.Collections.Generic;
using System.Text;

namespace ValidParentheses
{
    public class Solution
    {
        //19min
        public bool IsValid(string s)
        {
            //iterate over string

            
            Dictionary<char, char> correspondingBrackets = new Dictionary<char,char>
            {
                {')', '('},
                {'}', '{'},
                {']', '[' }
            };

            if (correspondingBrackets.ContainsKey(s[0])) return false;

            Stack<char> stackOpen = new Stack<char>();

            stackOpen.Push(s[0]);

            for(int i = 1; i < s.Length; i++)
            {
                if(correspondingBrackets.ContainsKey(s[i]))
                {
                    if (stackOpen.Count == 0) return false;

                    char lastOpen = stackOpen.Pop();

                    if (lastOpen != correspondingBrackets[s[i]])
                        return false;

                }
                else
                {
                    stackOpen.Push(s[i]);
                }
            }

            return stackOpen.Count == 0;
        }
    }
}
