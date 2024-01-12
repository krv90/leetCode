namespace LeetCodeTop150;

/// <summary>
/// 643. Maximum Average Subarray I
/// </summary>
public static class Exercise643
{
    public static double FindMaxAverage(int[] nums, int k)
    {
        double maxSum = nums.Take(k).Sum();

        double nextMaxSum = maxSum;
        for (int i = k; i < nums.Length; i++)
        {
            nextMaxSum = nextMaxSum + nums[i] - nums[i - k];
            if (nextMaxSum > maxSum)
            {
                maxSum = nextMaxSum;
            }
        }

        return maxSum / k;
    }
}