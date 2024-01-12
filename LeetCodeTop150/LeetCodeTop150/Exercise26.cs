namespace LeetCodeTop150;

/// <summary>
/// 26. Remove Duplicates from Sorted Array
/// </summary>
public static class Exercise26
{
    /// <returns>
    /// Then return the number of unique elements in nums
    /// </returns>
    public static int RemoveDuplicates(int[] nums) {
        if (nums.Length <= 1)
        {
            return nums.Length;
        }

        var uniqueIndex = 0;
        var uniqueVal = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != uniqueVal)
            {
                uniqueVal = nums[i];
                uniqueIndex++;
            }
            
            if (uniqueIndex > 0)
            {
                nums[uniqueIndex] = nums[i];
            }
        }
        
        return uniqueIndex >= 0 ? uniqueIndex + 1 : nums.Length;
    }
}