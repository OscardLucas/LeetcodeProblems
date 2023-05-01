using System;
using System.Collections.Generic;
using System.Text;

namespace RotateArray
{
    public class Solution
    {
        public void Rotate(int[] nums, int k)
        {
            k %= nums.Length;
            if (k == 0) return;

            int swaps = 0;

            int current = 0;

            while (swaps < nums.Length)
            {
                int start = current;
                int prev = nums[current];

                do
                {
                    int next = (current + k) % nums.Length;
                    int temp = nums[next];
                    nums[next] = prev;
                    prev = temp;
                    current = next;
                    swaps++;
                }
                while (current != start);
                current++;
            }
        }

        public void RotateWithDictionary(int[] nums, int k)
        {
            //Using dictionary
            Dictionary<int, int> indexVal = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int next = (i + k) % nums.Length;
                indexVal.TryAdd(next, nums[i]);
            }

            foreach (var n in indexVal)
            {
                nums[n.Key] = n.Value;
            }
        }

    }
}
