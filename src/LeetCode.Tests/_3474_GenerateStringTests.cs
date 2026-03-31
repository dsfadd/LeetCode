namespace LeetCode.Tests
{
    public class _3474_GenerateStringTests
    {
        [Fact]
        public void Example1()
        {
            var solver = new _3474_GenerateString();
            string str1 = "TFTF";
            string str2 = "ab";

            string expected = "ababa";
            string result = solver.Solve(str1, str2);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void Example2()
        {
            var solver = new _3474_GenerateString();
            string str1 = "F";
            string str2 = "d";

            string expected = "a";
            string result = solver.Solve(str1, str2);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void Example3()
        {
            var solver = new _3474_GenerateString();
            string str1 = "TFTF";
            string str2 = "abc";

            string expected = "";
            string result = solver.Solve(str1, str2);

            Assert.Equal(expected, result);
        }
    }
}
