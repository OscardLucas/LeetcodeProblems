using System;
using System.Collections.Generic;
using System.Text;

namespace HouseRobber
{
    public class Solution
    {
        public int Rob(int[] nums)
        {
            Dictionary<int, int> cache = new Dictionary<int, int>();
            return Math.Max(RobRecursive(nums, 0, cache), RobRecursive(nums, 1, cache));         
        }

        private int RobRecursive(int [] nums, int index, Dictionary<int, int> cache)
        {
            if (cache.ContainsKey(index))
                return cache[index];

            if (index >= nums.Length)
                return 0;

            return cache[index] = nums[index] + Math.Max(RobRecursive(nums, index + 2, cache), RobRecursive(nums, index + 3, cache));
        }
    }
}
