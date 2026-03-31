namespace LeetCode
{
    public class _1876_CountGoodSubstrings
    {
        public const string url = "https://leetcode.com/problems/substrings-of-size-three-with-distinct-characters/description/";

        public int Solve(string s)
        {
            int count = 0;
            for (int i = 0; i <= s.Length - 3; i++)
            {
                if ((s[i] != s[i + 1]) && (s[i] != s[i + 2]) && (s[i + 1] != s[i + 2]))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
