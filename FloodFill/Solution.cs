using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FloodFill
{
    public class Solution
    {
        //55min
        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            int[][] cache = new int[image.Length][];

            for(int i = 0; i < image.Length; i++)
            {
                for(int j = 0; j < image[0].Length; j++)
                {
                    if (cache[i] == null)
                        cache[i] = new int[image[0].Length];

                    cache[i][j] = -1;
                }
            }

            return FloodFillR(image, sr, sc, image[sr][sc], color, cache);

        }

        private int[][] FloodFillR(int[][] image, int sr, int sc, int prevColor, int color, int [][] cache)
        {
            if (sr >= image.Length || sc >= image[0].Length || sr < 0 || sc < 0)
                return image;

            if (cache[sr][sc] != -1)
                return image;

            cache[sr][sc] = 1;

            if (image[sr][sc] == prevColor)
            {
                image[sr][sc] = color;
            }
            else
            {
                return image;
            }
                

            FloodFillR(image, sr + 1, sc, prevColor ,color, cache);
            FloodFillR(image, sr - 1, sc, prevColor, color, cache);
            FloodFillR(image, sr, sc + 1, prevColor,  color, cache);
            FloodFillR(image, sr, sc - 1, prevColor, color, cache);

            return image;
        }
    }
}
