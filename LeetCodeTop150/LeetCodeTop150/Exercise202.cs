namespace LeetCodeTop150;

/// <summary>
/// 202. Happy number
/// </summary>
/// <remarks>
/// A happy number is a number defined by the following process:
/// - Starting with any positive integer, replace the number by the sum of the squares of its digits.
/// - Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
/// - Those numbers for which this process ends in 1 are happy.
/// </remarks>
public static class Exercise202
{
    public static bool IsHappy(int n)
    {
        var calculated = new HashSet<int>();
        
        while (true)
        {
            if (n == 1)
            {
                return true;
            }
            
            var digits = new List<int>();
            var source = n;

            while (source > 0)
            {
                var digit = source % 10;
                source /= 10;
                digits.Add(digit);
            }

            n = digits.Sum(d => d * d);
            if (calculated.Contains(n))
            {
                return false;
            }

            calculated.Add(n);
        }
    }
}