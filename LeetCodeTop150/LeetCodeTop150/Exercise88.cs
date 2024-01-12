namespace LeetCodeTop150;

/// <summary>
/// 88. Merge Sorted Array
/// </summary>
public static class Exercise88
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n) {
        var mi = m - 1;
        var ni = n - 1;

        for (var i = m + n - 1; i >= 0; i--)
        {
            nums1[i] = mi < 0 || (ni >= 0 && nums1[mi] < nums2[ni])
                ? nums2[ni--]
                : nums1[mi--];
        }
    }
}