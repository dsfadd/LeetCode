namespace LeetCode.Tests
{
    public class _1876_CountGoodSubstringsTests
    {
        [Fact]
        public void Example1()
        {
            var solver = new _1876_CountGoodSubstrings();
            string s = "xyzzaz";

            int expected = 1;
            int result = solver.Solve(s);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void Example2()
        {
            var solver = new _1876_CountGoodSubstrings();
            string s = "aababcabc";

            int expected = 4;
            int result = solver.Solve(s);

            Assert.Equal(expected, result);
        }
    }
}
