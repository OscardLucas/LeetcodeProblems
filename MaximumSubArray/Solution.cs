using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumSubArray
{
    public class Solution
    {
        //Given an integer array nums, find the subarray with the largest sum, and return its sum.

        //Constrains
        //1 <= nums.Length <= 10^5
        //-10^4 <= nums[i] <= 10^4

        //-2, 1, -3, 4, -1, 2, 1, -5, 4  
        //5, 4, -1, 7, 8
        //-3, -2, 0, -1 

        public int MaxSubArray(int[] nums)
        {
            int maxSum = nums[0];
            uint length = (uint)nums.Length;

            int currentSum = nums[0] < 0 ? 0 : nums[0] ;

            for(uint i = 1; i < length; i++)
            {
                currentSum += nums[i];

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
                if (currentSum < 0)
                {
                    currentSum = 0;
                }              
            }

            return maxSum;
        }
    }
}
