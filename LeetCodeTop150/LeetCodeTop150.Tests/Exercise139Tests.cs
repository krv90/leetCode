using NUnit.Framework;

namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise139Tests
{
    [Test]
    public void Case1()
    {
        var s = "leetcode";
        var wordDict = new[] { "leet", "code" };

        Exercise139.WordBreak(s, wordDict).Should().Be(true);
    }
    
    [Test]
    public void Case2()
    {
        var s = "applepenapple";
        var wordDict = new[] { "apple","pen" };

        Exercise139.WordBreak(s, wordDict).Should().Be(true);
    }
    
    [Test]
    public void Case3()
    {
        var s = "catsandog";
        var wordDict = new[] { "cats","dog","sand","and","cat" };

        Exercise139.WordBreak(s, wordDict).Should().Be(false);
    }
    
    [Test]
    public void Case4()
    {
        var s = "acaaaaabbbdbcccdcdaadcdccacbcccabbbbcdaaaaaadb";
        var wordDict = new[] { 
            "abbcbda","cbdaaa","b", "dadaaad","dccbbbc","dccadd",
            "ccbdbc","bbca","bacbcdd", "a","bacb","cbc","adc",
            "c","cbdbcad","cdbab", "db","abbcdbd","bcb",
            "bbdab", "aa","bcadb", "bacbcb","ca","dbdabdb",
            "ccd","acbb","bdc","acbccd","d","cccdcda",
            "dcbd","cbccacd","ac","cca","aaddc", "dccac",
            "ccdc","bbbbcda","ba","adbcadb", "dca","abd",
            "bdbb","ddadbad","badb","ab","aaaaa","acba","abbb"
        };

        Exercise139.WordBreak(s, wordDict).Should().Be(true);
    }
}