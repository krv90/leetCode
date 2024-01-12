namespace LeetCodeTop150;

/// <summary>
/// 139. Word Break
/// </summary>
public static class Exercise139
{
    public static bool WordBreak(string s, IList<string> wordDict)
    {
        var wordsChains = new HashSet<string> { s };

        var i = 0;
        while (wordsChains.Any() && i <= 300_000)
        {
            var chain = wordsChains.First();
            
            foreach (var word in wordDict)
            {
                if (!chain.StartsWith(word)) continue;

                if (chain.Length == word.Length)
                    return true;

                var withoutWord = chain.Substring(word.Length, chain.Length - word.Length);
                wordsChains.Add(withoutWord);
            }

            wordsChains.Remove(chain);

            i++;
        }

        return false;
    }
}