namespace LeetCodeTop150;

/// <summary>
/// 290. Word Pattern
/// </summary>
public static class Exercise290
{
    public static bool WordPattern(string pattern, string s)
    {
        var byCharMap = new Dictionary<char, string>();

        var i = 0;
        foreach (var word in s.Split(' '))
        {
            if (i >= pattern.Length)
            {
                return false;
            }
            
            var ch = pattern[i];
            if (!byCharMap.TryGetValue(ch, out var existentWord))
            {
                if (byCharMap.ContainsValue(word))
                {
                    return false;
                }

                byCharMap.Add(ch, word);
            }
            else if (word != existentWord)
            {
                return false;
            }

            i++;
        }
        
        return i == pattern.Length;
    }
}