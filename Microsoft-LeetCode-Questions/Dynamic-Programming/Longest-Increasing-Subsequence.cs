public class Solution
{
    // time complexity = O(n^2)
    // space complexity = 0(n) the declaration and usage of dp array
    public int LengthOfLIS(int[] nums)
    {
        if (nums.Length == 0) return 0;
        int max = 0;
        int[] dp = new int[nums.Length];
        Array.Fill(dp, 1);

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (nums[j] < nums[i])
                {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }

        }
        foreach (var x in dp)
        {
            max = Math.Max(max, x);
        }
        return max;
    }
}