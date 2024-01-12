namespace LeetCodeTop150;

/// <summary>
/// 209. Minimum Size Subarray Sum
/// </summary>
public static class Exercise209
{
    public  static int MinSubArrayLen(int target, int[] nums)
    {
        var result = 0;
        
        var sum = 0;
        var n = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if (result > 0)
                sum -= nums[i - n];
            else
                n++;

            if (sum < target)
                continue;

            result = n;

            for (n -= 1; n >= 1; n--)
            {
                sum -= nums[i - n];
                if (sum < target)
                {
                    sum += nums[i - n];
                    n++;

                    break;
                }

                result = n;
            }

            if (result == 1)
                break;
        }

        return result;
    }
}