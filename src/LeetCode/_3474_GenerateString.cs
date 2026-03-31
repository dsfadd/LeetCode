namespace LeetCode
{
    public class _3474_GenerateString
    {
        public const string url = "https://leetcode.com/problems/lexicographically-smallest-generated-string/description/";

        public string Solve(string str1, string str2)
        {
            int n = str1.Length;
            int m = str2.Length;
            int len = n + m - 1;

            char[] ans = new char[len];
            Array.Fill(ans, 'a');

            bool[] locked = new bool[len];

            for (int i = 0; i < n; i++)
            {
                if (str1[i] != 'T') continue;

                for (int j = 0; j < m; j++)
                {
                    int idx = i + j;

                    if (locked[idx] && ans[idx] != str2[j])
                        return "";

                    ans[idx] = str2[j];
                    locked[idx] = true;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (str1[i] != 'F') continue;

                if (!IsEqual(ans, i, str2))
                    continue;

                bool fixedOk = false;

                for (int j = m - 1; j >= 0 && !fixedOk; j--)
                {
                    int idx = i + j;

                    if (locked[idx]) continue;

                    char original = ans[idx];

                    for (char c = 'a'; c <= 'z'; c++)
                    {
                        if (c == original) continue;

                        ans[idx] = c;

                        if (!BreaksAnyT(ans, str1, str2))
                        {
                            locked[idx] = true;
                            fixedOk = true;
                            break;
                        }
                    }

                    if (!fixedOk)
                        ans[idx] = original;
                }

                if (!fixedOk)
                    return "";
            }

            return new string(ans);
        }

        bool IsEqual(char[] ans, int start, string str2)
        {
            for (int i = 0; i < str2.Length; i++)
                if (ans[start + i] != str2[i])
                    return false;
            return true;
        }

        bool BreaksAnyT(char[] ans, string str1, string str2)
        {
            int n = str1.Length;
            int m = str2.Length;

            for (int i = 0; i < n; i++)
            {
                if (str1[i] != 'T') continue;

                for (int j = 0; j < m; j++)
                {
                    if (ans[i + j] != str2[j])
                        return true;
                }
            }
            return false;
        }
    }
}
