namespace LeetCodeTop150;

/// <summary>
/// 53. Maximum Subarray
/// </summary>
public static class Exercise53
{
    public static int MaxSubArraySum(int[] nums)
    {
        var currentSum = nums[0];
        var maxSum = currentSum;
        
        for (int i = 1; i < nums.Length; i++)
        {
            currentSum += nums[i];

            if (currentSum < nums[i])
                currentSum = nums[i];
            
            if (maxSum < currentSum) 
                maxSum = currentSum;
        }

        return maxSum;
    }
}