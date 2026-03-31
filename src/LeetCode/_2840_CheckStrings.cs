namespace LeetCode
{
    public class _2840_CheckStrings
    {
        public const string url = "https://leetcode.com/problems/check-if-strings-can-be-made-equal-with-operations-ii/description/";

        public bool Solve(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            var count = new int[2, 26];

            for (int i = 0; i < s1.Length; i++)
            {
                int parity = i & 1;

                count[parity, s1[i] - 'a']++;
                count[parity, s2[i] - 'a']--;
            }

            for (int p = 0; p < 2; p++)
            {
                for (int c = 0; c < 26; c++)
                {
                    if (count[p, c] != 0)
                        return false;
                }
            }

            return true;
        }
    }
}
