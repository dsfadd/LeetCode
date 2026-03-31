namespace LeetCode.Tests
{
    public class _2293_MinMaxGameTests
    {
        [Fact]
        public void Example1()
        {
            var solver = new _2293_MinMaxGame();
            int[] nums = [1, 3, 5, 2, 4, 8, 2, 2];

            int expected = 1;
            int result = solver.Solve(nums);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void Example2()
        {
            var solver = new _2293_MinMaxGame();
            int[] nums = [3];

            int expected = 3;
            int result = solver.Solve(nums);

            Assert.Equal(expected, result);
        }
    }
}
