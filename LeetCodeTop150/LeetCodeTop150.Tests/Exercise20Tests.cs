using NUnit.Framework;

namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise20Tests
{
    [TestCase("()", true)]
    [TestCase("()[]{}", true)]
    [TestCase("(]", false)]
    public void IsValidCases(string s, bool expected)
    {
        Exercise20.IsValid(s).Should().Be(expected);
    }
    
    [TestCase("()", true)]
    [TestCase("()[]{}", true)]
    [TestCase("(]", false)]
    public void IsValid2Cases(string s, bool expected)
    {
        Exercise20.IsValid2(s).Should().Be(expected);
    }
}