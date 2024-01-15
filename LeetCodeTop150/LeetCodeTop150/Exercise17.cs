namespace LeetCodeTop150;

/// <summary>
/// 17. Letter Combinations of a Phone Number
/// </summary>
/// <see cref="https://habr.com/ru/companies/otus/articles/746408/"/>
public static class Exercise17
{
    private static readonly Dictionary<int, string[]> CharsByDigit = new Dictionary<int, string[]>
    {
        { '2', new[] { "a", "b", "c" } },
        { '3', new[] { "d", "e", "f" } },
        { '4', new[] { "g", "h", "i" } },
        { '5', new[] { "j", "k", "l" } },
        { '6', new[] { "m", "n", "o" } },
        { '7', new[] { "p", "q", "r", "s" } },
        { '8', new[] { "t", "u", "v" } },
        { '9', new[] { "w", "x", "y", "z" } }
    };

    public static IList<string> LetterCombinations(string digits)
    {
        if (digits?.Any() != true)
            return Array.Empty<string>();

        var result = new List<string>(CharsByDigit[digits[0]]);

        for (var i = 1; i < digits.Length; i++)
        {
            result = result.Join(
                    CharsByDigit[digits[i]],
                    _ => true,
                    _ => true,
                    (r, c) => r + c)
                .ToList();
        }

        return result;
    }
}