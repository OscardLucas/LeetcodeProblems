using System;
using System.Collections.Generic;
using System.Text;

namespace BestTimeToBuyAndSellStock
{
    public class Solution
    {
        //8min
        public int MaxProfit(int[] prices)
        {
            int lower = prices[0], profit = 0;

            for(int i = 1; i < prices.Length; i++)
            {
                int currentProfit = prices[i] - lower;

                if(currentProfit > profit )
                {
                    profit = currentProfit;
                }

                if(prices[i] < lower)
                {
                    lower = prices[i];
                }
            }

            return profit;

        }
    }
}
