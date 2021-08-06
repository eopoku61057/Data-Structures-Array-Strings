public class Solution
{
    int row = 0;
    int col = 0;
    public int NumIslands(char[][] grid)
    {
        row = grid.Length;
        col = grid[0].Length;
        int numIsland = 0;

        for(int i = 0; i <= row - 1; i++)
        {
            for(int j = 0; j <= col - 1; j++)
            {
                if(grid[i][j] == '1')
                {
                    numIsland++;
                    grid[i][j] = '0';
                    MarkVisited(grid, i, j);
                }
            }
        }
        return numIsland;
    }

    private void MarkVisited(char[][] grid, int k, int l)
    {
        if(k - 1 >= 0 && grid[k - 1][l] == '1')
        {
            grid[k - 1][l] = '0';
            MarkVisited(grid, k - 1, l);
        }
        if(l - 1 >= 0 && grid[k][l -1] == '1')
        {
            grid[k][l - 1] = '0';
            MarkVisited(grid, k, l - 1);
        }
        if(k + 1 < row && grid[k + 1][l] == '1')
        {
            grid[k + 1][l] = '0';
            MarkVisited(grid, k + 1, l);
        }
        if(l + 1 < col && grid[k][l + 1])
        {
            grid[k][l + 1] = '0';
            MarkVisited(grid, k, l + 1);
        }
    }
}