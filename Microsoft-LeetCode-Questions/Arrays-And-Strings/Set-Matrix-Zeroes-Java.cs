class Solution
{

    final int DIRECTION_UP = 1;
    final int DIRECTION_DOWN = 2;
    final int DIRECTION_LEFT = 3;
    final int DIRECTION_RIGHT = 4;

    public void setZeroes(int[][] matrix)
    {
        int[][] prev = new int[matrix.length][matrix[0].length];
        for (int i = 0; i < matrix.length; i++)
        {
            for (int j = 0; j < matrix[0].length; j++)
            {
                if (matrix[i][j] == 0 && prev[i][j] == 0)
                {
                    set(matrix, DIRECTION_UP, i - 1, j, prev);
                    set(matrix, DIRECTION_DOWN, i + 1, j, prev);
                    set(matrix, DIRECTION_LEFT, i, j - 1, prev);
                    set(matrix, DIRECTION_RIGHT, i, j + 1, prev);
                }
            }
        }
    }

    public void set(int[][] matrix, int direction, int i, int j, int[][] prev)
    {
        if (i < 0 || i >= matrix.length || j < 0 || j >= matrix[0].length) return;
        if (matrix[i][j] != 0)
        {
            matrix[i][j] = 0;
            prev[i][j] = 1;
        }
        if (direction == DIRECTION_UP)
        {
            set(matrix, DIRECTION_UP, i - 1, j, prev);
        }
        if (direction == DIRECTION_DOWN)
        {
            set(matrix, DIRECTION_DOWN, i + 1, j, prev);
        }
        if (direction == DIRECTION_LEFT)
        {
            set(matrix, DIRECTION_LEFT, i, j - 1, prev);
        }
        if (direction == DIRECTION_RIGHT)
        {
            set(matrix, DIRECTION_RIGHT, i, j + 1, prev);
        }
    }
}