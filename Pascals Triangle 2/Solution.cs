using System;
using System.Collections.Generic;
using System.Text;

namespace PascalsTriangle2
{
    public class Solution
    {
        public IList<int> GetRow(int rowIndex)
        {
            int[] row = new int[1] {1};

            for(int i = 1; i < rowIndex+1; i++)
            {
                int[] newRow = new int[i + 1];
                newRow[0] = 1;
                newRow[^1] = 1;
                for(int j = 1; j < newRow.Length - 1; j++)
                {
                    newRow[j] = row[j-1] + row[j];
                }
                row = newRow;
            }

            return row;
        }

        public IList<int> GetRowBruteForce(int rowIndex) {
            int[][] triangle = new int[rowIndex + 1][];

            for (int i = 0; i < triangle.Length; i++)
            {
                triangle[i] = new int[i + 1];
                triangle[i][0] = 1;
                triangle[i][^1] = 1;
                for (int j = 1; j < triangle[i].Length - 1; j++)
                {
                    triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                }
            }

            return triangle[^1];
        }
    }
}
