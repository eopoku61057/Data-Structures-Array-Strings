/*
    There are 2N people a company is planning to interview. The cost of flying the i-th person to city A is costs[i][0], 
    and the cost of flying the i-th person to city B is costs[i][1].
    Return the minimum cost to fly every person to a city such that exactly N people arrive in each city.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    { // delete Node from a linked list
        public int TwoCitySchedCost(int[][] costs)
        {
            DoComparison dc = new DoComparison();
            Array.Sort(costs, dc);

            int n = costs.Length / 2;
            int res = 0;
            int countA = 0, countB = 0;

            for(int i = 0; i < costs.Length; i++)
            {
                if (countA < n && countB < n)
                {
                    if (costs[i][0] < costs[i][1])
                    {
                        countA++;
                        res += costs[i][0];
                    }
                    if (costs[i][0] >= costs[i][1])
                    {
                        countB++;
                        res += costs[i][1];
                    }
                }
                else if(countA < n)
                {
                    countA++;
                    res += costs[i][0];
                }
                else if (countB < n)
                {
                    countB++;
                    res += costs[i][1];
                }
            }
            return res;
        }

    }

    public class DoComparison : IComparer<int[]>
    {
        public int Compare(int[] a, int[] b)
        {
            return Math.Abs(b[0] - b[1]) - Math.Abs(a[0] - a[1]);
        }
    }
}
