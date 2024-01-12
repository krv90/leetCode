namespace LeetCodeTop150;

/*
* Given an array of strings nums containing n unique binary strings each of length n, 
* return a binary string of length n that does not appear in nums.
* If there are multiple answers, you may return any of them.
*/
public static class Exercise1980
{
    /// <summary>
    /// 1980. Find Unique Binary String
    /// </summary>
    public static string FindDifferentBinaryString(string[] nums)
    {
        string Format(int i) => Convert.ToString(i, 2).PadLeft(nums[0].Length, '0');

        var orderedNums = nums
            .Select(str => Convert.ToInt32(str, 2))
            .OrderBy(num => num)
            .ToArray();

        if (orderedNums[0] > 0)
        {
            return Format(0);
        }

        for (var i = 1; i < orderedNums.Length; i++)
        {
            var delta = orderedNums[i] - orderedNums[i-1];
            if (delta > 1)
            {
                return Format(orderedNums[i-1] + 1);
            }
        }

        return Format(orderedNums[^1] + 1);
    }
}