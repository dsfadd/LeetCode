namespace LeetCode.Tests
{
    public class _2840_CheckStringsTests
    {
        [Fact]
        public void Example1()
        {
            var solver = new _2840_CheckStrings();
            string s1 = "abe";
            string s2 = "bea";

            bool expected = false;

            bool result = solver.Solve(s1,s2);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void Example2()
        {
            var solver = new _2840_CheckStrings();
            string s1 = "abcdba";
            string s2 = "cabdab";

            bool expected = true;

            bool result = solver.Solve(s1,s2);

            Assert.Equal(expected, result);
        }
    }
}
