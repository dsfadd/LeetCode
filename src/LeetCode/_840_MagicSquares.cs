namespace LeetCode
{
    public class _840_MagicSquares
    {
        public const string url = "https://leetcode.com/problems/magic-squares-in-grid/description/";

        public int Solve(int[][] grid)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;
            int count = 0;

            for (int i = 0; i < rows - 2; i++)
            {
                for (int j = 0; j < cols - 2; j++)
                {
                    if (IsMagic(grid, i, j))
                        count++;
                }
            }

            return count;
        }

        private bool IsMagic(int[][] g, int r, int c)
        {
            if (g[r + 1][c + 1] != 5)
                return false;

            int mask = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int val = g[r + i][c + j];

                    if (val < 1 || val > 9)
                        return false;

                    int bit = 1 << val;

                    if ((mask & bit) != 0)
                        return false;

                    mask |= bit;
                }
            }

            int sum =
                g[r][c] + g[r][c + 1] + g[r][c + 2];

            return
                sum == g[r + 1][c] + g[r + 1][c + 1] + g[r + 1][c + 2] &&
                sum == g[r + 2][c] + g[r + 2][c + 1] + g[r + 2][c + 2] &&

                sum == g[r][c] + g[r + 1][c] + g[r + 2][c] &&
                sum == g[r][c + 1] + g[r + 1][c + 1] + g[r + 2][c + 1] &&
                sum == g[r][c + 2] + g[r + 1][c + 2] + g[r + 2][c + 2] &&

                sum == g[r][c] + g[r + 1][c + 1] + g[r + 2][c + 2] &&
                sum == g[r][c + 2] + g[r + 1][c + 1] + g[r + 2][c];
        }
    }
}
