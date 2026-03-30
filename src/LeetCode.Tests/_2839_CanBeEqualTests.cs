namespace LeetCode.Tests
{
    public class _2839_CanBeEqualTests
    {
        [Fact]
        public void Example1()
        {
            var solver = new _2839_CanBeEqual();
            string s1 = "abcd";
            string s2 = "cdab";

            bool expected = true;
            bool result = solver.Solve(s1,s2);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void Example2()
        {
            var solver = new _2839_CanBeEqual();
            string s1 = "abcd";
            string s2 = "dacb";

            bool expected = false;
            bool result = solver.Solve(s1,s2);

            Assert.Equal(expected, result);
        }
    }
}
