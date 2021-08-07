public class Solution
{
    private int row = 0;
    private int col = 0;
    public class Pos
    {
        public int row;
        public int col;
        public int distance;
        public Pos(int _row, int _col, int _distance)
        {
            row = _row;
            col = _col;
            distance = _distance;
        }
    }
    public int ShortestDistance(int[][] grid)
    {
        row = grid.Length;
        col = grid[0].Length;
        if (!CheckAvailable(grid)) return -1;

        int[][] sDistance = new int[row][col];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (grid[i][j] == 1)
                {
                    int[][] sDistancePos = GetShortestDistance(grid, i, j);
                    Add(grid, sDistance, sDistancePos);
                }

            }
        }

        int shortest = int.MaxValue;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                shortest = Math.Min(shortest, sDistance[i][j]);
            }
        }
        return shortest;

    }

    private void Add(int[][] grid, int[][] shortestD, int[][] sDistancePos)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (grid[i][j] == 1 || grid[i][j] == 2)
                {
                    shortestD[i][j] = int.MaxValue;
                    continue;
                }
                if (sDistancePos[i][j] == -1)
                {
                    shortestD[i][j] = int.MaxValue;
                    continue;
                }
                shortestD[i][j] += sDistancePos[i][j];
            }
        }
    }
    private int[][] GetShortestDistance(int[][] grid, int i, int j)
    {
        int[][] shortD = new int[row][col];
        for (int k = 0; k < row; k++)
        {
            for (int l = 0; l < col; l++)
            {
                shortD[k][l] = -1;
            }
        }
        Queue<Pos> queue = new LinkedList<>();
        queue.Enqueue(new Pos(i, j, 0));
        //shortD[i][j] = 0;
        while (queue.Any())
        {
            int queueLen = queue.Count();
            for (int k = 0; k < len; k++)
            {
                Pos p = queue.Dequeue();
                if ((grid[p.row][p.col] == 2 || grid[p.row][p.col] == 1
                  ) && !(p.row == i && p.row == j))
                {
                    continue;
                }
                if (shortD[p.row][p.col] != -1)
                {
                    shortD[p.row][p.col] = p.distance;
                    if (p.row > 0)
                    {
                        queue.Enqueue(new Pos(p.row - 1, p.col, p.distance + 1));
                    }
                    if (p.col > 0)
                    {
                        queue.Enqueue(new Pos(p.row, p.col - 1, p.distance + 1));
                    }
                    if (p.row < (row - 1))
                    {
                        queue.Enqueue(new Pos(p.row + 1, p.col, p.distance + 1));
                    }
                    if (p.col < (col - 1))
                    {
                        queue.Enqueue(new Pos(p.row, p.col + 1, p.distance + 1));
                    }
                }
            }
        }
        return shortD == int.MaxValue ? -1 : shortD;
    }
    private bool CheckAvailable(int[][] grid)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (grid[i][j] == 0)
                {
                    return true;
                }
            }
        }
        return false;
    }
}