namespace LeetCodeTop150;

/// <summary>
/// 35. Search Insert Position
/// </summary>
/// <remarks>
/// Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
/// You must write an algorithm with O(log n) runtime complexity.
/// </remarks>
public static class Exercise35
{
    public static int SearchInsert(int[] nums, int target)
    {
        var max = nums.Length;
        var min = 0;
        int i = -1;
        
        do
        {
            i = (int)Math.Floor((max - min) / 2d) + min;

            var current = nums[i];
            if (current == target)
            {
                return i;
            }

            if (target < current)
            {
                if (max == i)
                {
                    return i;
                }
                
                max = i;
            }
            else // current < target
            {
                if (min == i)
                {
                    return i + 1;
                }
                
                min = i;
            }
        } while (max - min > 0);

        return i;
    }
}