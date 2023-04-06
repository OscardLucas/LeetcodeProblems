using System;
using System.Collections.Generic;
using System.Text;

namespace UniquePaths
{
    public class Solution
    {
        public int UniquePaths(int m, int n)
        {
            if (m == 1 && n == 1) return 1;

            int[,] cache = new int[m, n];

            for(int j,i = 0; i < m; i++)
            {
                for(j = 0; j < n; j++)
                {
                    cache[i, j] = -1;
                }
            }

            return UniquePathsR(m, n, 1, 0, cache) + UniquePathsR(m, n, 0, 1, cache);
        }

        private int UniquePathsR(int rows, int cols, int x, int y, int[,] cache)
        {

            if (x >= cols || y >= rows)
                return 0;

            if (cache[y, x] != -1)
            {
                return cache[y, x];
            }

            if (x == (cols - 1) && y == (rows - 1))
                return 1;

            return cache[y,x] = UniquePathsR(rows, cols, x + 1, y, cache) + UniquePathsR(rows, cols, x, y + 1, cache);
            
        }

    }
}
