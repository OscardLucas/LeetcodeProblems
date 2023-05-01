using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MinimumSizeSubarraySum
{
    public class Solution
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            if(nums.Length  == 1)
            {
                return nums[0] >= target ? 1 : 0;
            }

            int left = 0;
            int right = 1;

            if (nums[left] >= target || nums[right] >= target)
                return 1;

            int sum = nums[left] + nums[right];

            int minLen = sum >= target ? 2 : int.MaxValue;

            while(true)
            {

                if(sum >= target && right - left > 1 && sum - nums[left] >= target)
                {

                    sum -= nums[left++];
                  
                }             
                else if(right + 1 <= nums.Length - 1)
                {
                    if (nums[++right] >= target) return 1;

                    sum += nums[right];
                }
                else
                {
                    break;
                }

                if(sum >= target && right - left + 1 < minLen)
                    minLen = right -left + 1;
   
            }

            return sum >= target ? minLen : 0;
        }
    }
}
