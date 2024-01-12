using NUnit.Framework.Internal;

namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise66Tests
{
    [Test]
    public void Case1()
    {
        var digits = new[] { 1, 2, 3 };

        var actual = Exercise66.PlusOne(digits);
        var expected =  new[] { 1, 2, 4 };

        actual.Should().BeEquivalentTo(expected, opt => opt.WithStrictOrdering());
    }
    
    [Test]
    public void Case2()
    {
        var digits = new[] { 4,3,2,1 };

        var actual = Exercise66.PlusOne(digits);
        var expected =  new[] { 4,3,2,2 };

        actual.Should().BeEquivalentTo(expected, opt => opt.WithStrictOrdering());
    }
    
    [Test]
    public void Case3()
    {
        var digits = new[] { 9 };

        var actual = Exercise66.PlusOne(digits);
        var expected =  new[] { 1, 0 };

        actual.Should().BeEquivalentTo(expected, opt => opt.WithStrictOrdering());
    }
    
    [Test]
    public void Case4()
    {
        var digits = new[] { 8,9,9,9 };

        var actual = Exercise66.PlusOne(digits);
        var expected =  new[] { 9,0,0,0 };

        actual.Should().BeEquivalentTo(expected, opt => opt.WithStrictOrdering());
    }
}