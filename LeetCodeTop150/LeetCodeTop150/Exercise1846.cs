namespace LeetCodeTop150;

/*
* - The value of the first element in arr must be 1.
* - The absolute difference between any 2 adjacent elements must be less than or equal to 1.
*
* There are 2 types of operations that you can perform any number of times:
* - Decrease the value of any element of arr to a smaller positive integer.
* - Rearrange the elements of arr to be in any order.
*/
public static class Exercise1846
{
    /// <summary>
    /// 1846. Maximum Element After Decreasing and Rearranging
    /// </summary>
    /// <returns>
    /// Return the maximum possible value of an element in arr after performing the operations to satisfy the conditions.
    /// </returns>
    public static int MaximumElementAfterDecrementingAndRearranging(int[] arr)
    {
        Array.Sort(arr);
        
        if (arr.Length > 0 && arr[0] != 1)
        {
            arr[0] = 1;
        }

        for (int i = 1; i < arr.Length; i++)
        {
            var delta = arr[i] - arr[i - 1];
            if (delta < -1  || delta > 1)
            {
                arr[i] = arr[i - 1] + 1;
            }
        }

        return arr[^1];
    }
}