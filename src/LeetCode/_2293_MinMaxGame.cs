namespace LeetCode
{
    public class _2293_MinMaxGame
    {
        public const string url = "https://leetcode.com/problems/min-max-game/description/";

        public int Solve(int[] nums)
        {
            int n = nums.Length;
            if (n == 1) return nums[0];

            int[] newNums = new int[n / 2];
            int numsIndex = 0;
            for (int i = 0; i < n / 2; i++)
            {
                if ((i & 1) == 0)
                {
                    newNums[i] = Min(nums[numsIndex], nums[numsIndex + 1]);
                    numsIndex += 2;
                }
                else
                {
                    newNums[i] = Max(nums[numsIndex], nums[numsIndex + 1]);
                    numsIndex += 2;
                }
            }

            return Solve(newNums);
        }
        private int Min(int a, int b)
        {
            if (a < b) return a;
            else return b;
        }
        private int Max(int a, int b)
        {
            if (a > b) return a;
            else return b;
        }
    }
}
