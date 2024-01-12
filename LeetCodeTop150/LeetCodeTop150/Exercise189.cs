namespace LeetCodeTop150;

/// <summary>
/// 189. Rotate Array
/// </summary>
/// <remarks>
/// Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.
/// </remarks>
public static class Exercise189
{
    public static void Solution1(int[] nums, int k)
    {
        if (k > nums.Length)
        {
            k %= nums.Length;
        }
        
        var resultArray = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            var newIndex = i + k;
            if (newIndex >= nums.Length)
            {
                newIndex -= nums.Length;
            }

            resultArray[newIndex] = nums[i];
        }
        
        resultArray.CopyTo(nums, 0);
    }
    
    // это решение, как ни странно, хуже...
    public static void Solution2(int[] nums, int k)
    {
        if (k > nums.Length)
        {
            k %= nums.Length;
        }
        
        var memArray = new int[k];
        for (int j = 0; j < k; j++)
        {
            memArray[j] = nums[nums.Length - k + j];
        }

        var i = nums.Length - k - 1;
        for (int newIndex = nums.Length - 1; newIndex >= 0; newIndex--)
        {
            nums[newIndex] = i < 0 ? memArray[newIndex] : nums[i];
            i--;
        }
    }
}