using System;
using System.Collections.Generic;
using System.Text;

namespace TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> complementByIndex = new Dictionary<int, int>();
            
            for(var i = 0; i < nums.Length; i++)
            {
                if(complementByIndex.ContainsKey(nums[i]))
                {
                    return new int[] { complementByIndex[nums[i]], i };
                }
                complementByIndex[target - nums[i]] = i;
            }

            return new int[2];
        }
    }
}
