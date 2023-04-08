using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{
    public class Solution
    {
        //60min looking o log n
        public int Search(int[] nums, int target)
        {
            
            if(nums.Length == 1)
            {
                if (nums[0] == target)
                    return 0;

                return -1;
            }

            int rightIndex = nums.Length - 1;
            int leftIndex = 0;
            int index = (rightIndex + leftIndex) / 2;

            while(leftIndex <= rightIndex)
            {
                if (target == nums[index])
                {
                    return index;
                }
                else if (target > nums[index])
                {
                    leftIndex = index + 1;

                }
                else
                {
                    rightIndex = index - 1;

                }
                index = (rightIndex + leftIndex) / 2;
            }
            

            return -1;
        }

    }
}
