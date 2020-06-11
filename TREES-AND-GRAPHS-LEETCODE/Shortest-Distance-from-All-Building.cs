using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    public class SortedZeros
    {
        public int ShortestDistance(int[][] grid)
        {
            if (grid == null || grid.Length == 0) return -1;
            int m = grid.Length, n = grid[0].Length;
            int[,] reach = new int[m,n];    // number of building can be reached from [i, j]
            int[,] distance = new int[m,n]; // total distance from [i, j] to all buildings
            int building = 0; // number of buildings

            Queue<(int, int)> queue = new Queue<(int, int)>();
            for(int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        building++;
                        BFS(grid, i, j, reach, distance);
                    }
                }
            }

            int minLen = Int32.MaxValue;
            for (int i = 0; i < m; i++)
            {
                for (int j= 0; j < n; j++)
                {
                    if (reach[i, j] == building)
                    {
                        minLen = Math.Max(minLen, distance[i, j]);
                    }
                }
            }

            return minLen == Int32.MaxValue ? -1 : minLen;
        }

        private void BFS(int[][] grid, int row, int col, int[,] reach, int[,] distance)
        {
            int m = grid.Length, n = grid[0].Length;
            int[,] dir = new int[,] { { -1, 0 }, { 1, 0 }, { 0, -1 }, { 0, 1 } };
            bool[,] visited = new bool[m, n];

            Queue<(int, int)> queue = new Queue<(int, int)>();
            queue.Enqueue((row, col));
            visited[row, col] = true;
            int curDistance = 0;

            while(queue.Any())
            {
                curDistance++;
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var curr = queue.Dequeue();
                    for (int j = 0; j < 4; j++)
                    {
                        int newRow = curr.Item1 + dir[j, 0];
                        int newCol = curr.Item2 + dir[j, 1];

                        if (newRow >= 0 && newRow < m && newCol >= 0 && newCol < n && !visited[newRow, newCol] && grid[newRow][newCol] == 0)
                        {
                            reach[newRow, newCol]++;
                            distance[newRow, newCol] += curDistance;
                            queue.Enqueue((newRow, newCol));
                            visited[newRow, newCol] = true;
                        }
                    }
                }
            }
        }
    }
}
