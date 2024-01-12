namespace LeetCodeTop150;

/// <summary>
/// 228. Summary Ranges
///
/// Return the smallest sorted list of ranges that cover all the numbers in the array exactly.
/// That is, each element of nums is covered by exactly one of the ranges,
/// and there is no integer x such that x is in one of the ranges but not in nums.
/// </summary>
/// <remarks>
/// Each range [a,b] in the list should be output as:
/// "a->b" if a != b
/// "a" if a == b
/// </remarks>
public static class Exercise228
{
    public static IList<string> SummaryRanges(int[] nums) {
        if (nums.Length == 0)
            return Array.Empty<string>();

        var result = new List<string>();
        var rangeStartIndex = 0;

        string NewRange(int startIndex, int endIndex)
        {
            return endIndex == startIndex
                ? $"{nums[startIndex]}"
                : $"{nums[startIndex]}->{nums[endIndex]}";
        }

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] - nums[i - 1] == 1) 
                continue;

            result.Add(NewRange(rangeStartIndex, i - 1));
                
            rangeStartIndex = i;
        }

        result.Add(NewRange(rangeStartIndex, nums.Length - 1));

        return result;
    }
}