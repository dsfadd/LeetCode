namespace LeetCode.Tests
{
    public class _840_MagicSquaresTests
    {
        [Fact]
        public void Example1()
        {
            var solver = new _840_MagicSquares();
            int[][] grid = [[4, 3, 8, 4], [9, 5, 1, 9], [2, 7, 6, 2]];

            int expected = 1;
            int result=solver.Solve(grid);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void Example2()
        {
            var solver = new _840_MagicSquares();
            int[][] grid = [[8]];

            int expected = 0;
            int result=solver.Solve(grid);

            Assert.Equal(expected, result);
        }
    }
}