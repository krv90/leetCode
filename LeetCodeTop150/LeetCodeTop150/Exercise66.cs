namespace LeetCodeTop150;

/// <summary>
/// 66. Plus One
/// </summary>
public static class Exercise66
{
    public static int[] PlusOne(int[] digits)
    {
        var result = new int[digits.Length];
        
        var plusOne = true;
        for (var i = digits.Length - 1; i >= 0; i--)
        {
            if (plusOne)
            {
                plusOne = digits[i] == 9;
                result[i] = plusOne ? 0 : digits[i] + 1;
            }
            else
            {
                result[i] = digits[i];
            }
        }

        if (!plusOne) 
            return result;

        var plusOneResult = new int[result.Length + 1];
        plusOneResult[0] = 1;

        return plusOneResult;
    }
}