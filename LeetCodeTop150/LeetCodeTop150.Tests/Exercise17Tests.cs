using NUnit.Framework;

namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise17Tests
{
    [Test]
    public void Case1()
    {
        Exercise17.LetterCombinations("23")
            .Should()
            .BeEquivalentTo(new[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" });
    }
    
    [Test]
    public void Case2()
    {
        Exercise17.LetterCombinations("2")
            .Should()
            .BeEquivalentTo(new[] { "a", "b", "c" });
    }
}