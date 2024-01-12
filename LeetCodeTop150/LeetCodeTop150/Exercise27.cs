namespace LeetCodeTop150;

/// <summary>
/// 27. Remove Element
/// </summary>
public static class Exercise27
{
    /// <returns>
    /// Then return the number of elements in nums which are not equal to val.
    /// </returns>
    public static int RemoveElement(int[] nums, int val)
    {
        var moveTo = -1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                moveTo = moveTo == -1 ? i : moveTo;
                nums[i] = -1;
            }
            
            if (moveTo >= 0 && nums[i] != -1)
            {
                nums[moveTo] = nums[i];
                moveTo++;
            }
        }
        
        return moveTo >= 0 ? moveTo : nums.Length;
    }
}