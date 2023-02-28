using System;
using System.Collections.Generic;
using System.Text;

namespace NumberOfIslands
{
    public class Solution
    {
        //["1","1","0","0","0"],
        //["1","1","0","0","0"],
        //["0","0","1","0","0"],
        //["0","0","0","1","1"]
        public int NumIslands(char[][] grid)
        {
            //Search for land
            int rows = grid.Length, cols = grid[0].Length, islands = 0;

            for(int j,i = 0; i < rows; i++)
            {
                for(j = 0; j < cols; j++)
                {
                    if(grid[i][j] == '1')
                    {
                        islands++;
                        SetIslandFound(grid, i, j, rows, cols);

                    }
                }
            }

            return islands;
           
        }

        public void SetIslandFound(char[][]grid, int row, int col, int limitRow, int limitCol)
        {
            //Stop recursive call
            if (row < 0 || col < 0 || row >= limitRow || col >= limitCol || grid[row][col] != '1')
                return;

            //Search by adjacents horizontally and vertically
            grid[row][col] = '_'; //Set as counted

            SetIslandFound(grid, row + 1, col, limitRow, limitCol);
            SetIslandFound(grid, row - 1, col, limitRow, limitCol);
            SetIslandFound(grid, row, col + 1, limitRow, limitCol);
            SetIslandFound(grid, row, col - 1, limitRow, limitCol);

        }
    }
}
