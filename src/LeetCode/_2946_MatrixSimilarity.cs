namespace LeetCode
{
    public class _2946_MatrixSimilarity
    {
        public const string url = "https://leetcode.com/problems/matrix-similarity-after-cyclic-shifts/description/";

        public bool Solve(int[][] mat, int k)
        {
            int rows = mat.Length;

            for (int i = 0; i < rows; i++)
            {
                int cols = mat[i].Length;
                int shift = k % cols;

                for (int j = 0; j < cols; j++)
                {
                    int expectedIndex;

                    if ((i & 1) == 0)
                    {
                        expectedIndex = (j + shift) % cols;
                    }
                    else
                    {
                        expectedIndex = (j - shift + cols) % cols;
                    }

                    if (mat[i][j] != mat[i][expectedIndex])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
