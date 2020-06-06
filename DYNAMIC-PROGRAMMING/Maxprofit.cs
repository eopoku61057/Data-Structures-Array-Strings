/*
  Say you have an array for which the ith element is the price of a given stock on day i.
  If you were only permitted to complete at most one transaction (i.e., buy one and sell one share of the stock), design an algorithm to find the maximum profit.
  Note that you cannot sell a stock before you buy one.
 */

 using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    {
        // Time Complexity: 0(N)
        // Space Complexity: 0(1)
        public int maxProfit(int[] prices)
        {
            int minprice = int.MaxValue;
            int maxprofit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if(prices[i] < minprice)
                {
                    minprice = prices[i];
                }
                else if (prices[i] - minprice > maxprofit)
                {
                    maxprofit = prices[i] - minprice;
                }
            }
            return maxprofit;
        }
    }
}
