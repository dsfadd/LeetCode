namespace LeetCode.Tests
{
    public class _2946_MatrixSimilarityTests
    {
        [Fact]
        public void Example1()
        {
            var solver = new _2946_MatrixSimilarity();
            int[][] mat = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
            int k = 4;

            bool expected = false;
            bool result = solver.Solve(mat, k);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void Example2()
        {
            var solver = new _2946_MatrixSimilarity();
            int[][] mat = [[1, 2, 1, 2], [5, 5, 5, 5], [6, 3, 6, 3]];
            int k = 2;

            bool expected = true;
            bool result = solver.Solve(mat, k);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void Example3()
        {
            var solver = new _2946_MatrixSimilarity();
            int[][] mat = [[2, 2], [2, 2]];
            int k = 3;

            bool expected = true;
            bool result = solver.Solve(mat, k);

            Assert.Equal(expected, result);
        }
    }
}