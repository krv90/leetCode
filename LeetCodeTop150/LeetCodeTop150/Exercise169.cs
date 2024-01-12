namespace LeetCodeTop150;

public static class Exercise169
{
    /// <summary>
    /// 169. Majority Element
    /// </summary>
    /// <returns>
    /// Given an array nums of size n, return the majority element.
    /// The majority element is the element that appears more than ⌊n / 2⌋ times
    /// </returns>
    public static int MajorityElement(int[] nums)
    {
        var frequency = new Dictionary<int, int>();
        var i = 0;

        while (i < nums.Length)
        {
            var current = nums[i];
            var currentFrequency = frequency.TryGetValue(current, out var value) ? value + 1 : 1;
            frequency[current] = currentFrequency;

            if (currentFrequency > nums.Length / 2)
            {
                return current;
            }

            i++;
        }

        return -1;
    }
}