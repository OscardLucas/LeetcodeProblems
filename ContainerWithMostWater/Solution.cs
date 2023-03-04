using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerWithMostWater
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int i = 0, j = height.Length - 1;
            int maxArea = GetArea(height[i] < height[j] ? height[i] : height[j], j - i);

            if (height.Length == 2)
            {
                return maxArea;
            };

            int tempLeftLine = height[0], tempRightLine = height[j], tempArea = 0;

            while (i != j)
            {
                if (height[i] <= height[j])
                {
                    i++;
                    tempLeftLine = height[i];
                }
                else
                {
                    j--;
                    tempRightLine = height[j];
                }

                tempArea = GetArea(tempLeftLine < tempRightLine ? tempLeftLine : tempRightLine, j - i);

                if (tempArea > maxArea)
                {
                    maxArea = tempArea;
                }
            }
            return maxArea;
        }

        private int GetArea(int height, int length)
        {
            return height * length;
        }
    }
}
