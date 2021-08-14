public class Solution
{
    private int Direction_Up = 1;
    private int Direction_Down = 2;
    private int Direction_Left = 3;
    private int Direction_Right = 4;
    public void SetZeroes(int[][] matrix)
    {
        int[,] prev = new int[matrix.Length, matrix[0].Length];
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] == 0 && prev[i, j] == 0)
                {
                    set(matrix, Direction_Up, i - 1, j, prev);
                    set(matrix, Direction_Down, i + 1, j, prev);
                    set(matrix, Direction_Left, i, j - 1, prev);
                    set(matrix, Direction_Right, i, j + 1, prev);
                }
            }
        }
    }
    private void set(int[][] matrix, int direction, int i, int j, int[,] prev)
    {
        if (matrix[i][j] != 0)
        {
            matrix[i][j] = 0;
            prev[i, j] = 1;
        }
        if (direction == Direction_Up)
        {
            set(matrix, Direction_Up, i - 1, j, prev);
        }
        if (direction == Direction_Down)
        {
            set(matrix, Direction_Down, i + 1, j, prev);
        }
        if (direction == Direction_Left)
        {
            set(matrix, Direction_Left, i, j - 1, prev);
        }
        if (direction == Direction_Right)
        {
            set(matrix, Direction_Right, i, j + 1, prev);
        }
    }
}