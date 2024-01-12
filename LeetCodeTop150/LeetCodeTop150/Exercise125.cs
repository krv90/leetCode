namespace LeetCodeTop150;

/// <summary>
/// 125. Valid Palindrome
/// </summary>
public static class Exercise125
{
    /// <summary>
    /// Given a string s, return true if it is a palindrome, or false otherwise.
    /// </summary>
    public static bool IsPalindrome(string s)
    {
        var headIndex = 0;
        var tailIndex = s.Length - 1;

        while (headIndex <= tailIndex)
        {
            var headSymbol = s[headIndex];
            while (!IsLetterOrNumber(headSymbol) && headIndex < s.Length - 1)
            {
                headSymbol = s[++headIndex];
            }
            
            var tailSymbol = s[tailIndex];
            while (!IsLetterOrNumber(tailSymbol) && tailIndex > 0)
            {
                tailSymbol = s[--tailIndex];
            }

            if (headIndex <= tailIndex &&
                char.ToLowerInvariant(headSymbol) != char.ToLowerInvariant(tailSymbol))
            {
                return false;
            }
            
            headIndex++;
            tailIndex--;
        }
        
        return true;
    }

    private static bool IsLetterOrNumber(char symbol)
    {
        return char.IsLetter(symbol) || char.IsNumber(symbol);
    }
}