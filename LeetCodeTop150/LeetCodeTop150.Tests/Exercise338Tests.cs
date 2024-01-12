using NUnit.Framework;

namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise338Tests
{
    [Test]
    public void Case1()
    {
        Exercise338.CountBits_O_n(2)
            .Should()
            .BeEquivalentTo(new[] { 0, 1, 1 }, opt => opt.WithStrictOrdering());
    }
    [Test]
    public void Case2()
    {
        Exercise338.CountBits_O_n(5)
            .Should()
            .BeEquivalentTo(new[] { 0,1,1,2,1,2 }, opt => opt.WithStrictOrdering());
    }
}