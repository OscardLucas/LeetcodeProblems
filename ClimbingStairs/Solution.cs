using System;
using System.Collections.Generic;
using System.Text;

namespace ClimbingStairs
{
    public class Solution
    {
        public int ClimbStairs(int n)
        {
            return ClimbStairsRecursive(n, new int[n]);
        }

        //3
        private int ClimbStairsRecursive(int n, int [] cache)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 2;

            if (cache[n-1] != 0)
                return cache[n-1];
            
            return cache[n-1] = ClimbStairsRecursive(n - 1, cache) + ClimbStairsRecursive(n - 2, cache); 
        }
    }
}
