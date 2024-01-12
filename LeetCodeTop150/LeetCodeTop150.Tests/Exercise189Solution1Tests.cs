using NUnit.Framework;

namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise189Solution1Tests
{
    [Test]
    public void Case1()
    {
        var nums = new [] { 1,2,3,4,5,6,7 };
        const int k = 3;

        Exercise189.Solution1(nums, k);
        var expected = new[] { 5, 6, 7, 1, 2, 3, 4 };

        nums.Should().BeEquivalentTo(expected, c => c.WithStrictOrderingFor(x => x));
    }
    
    [Test]
    public void Case2()
    {
        var nums = new [] { -1,-100,3,99 };
        const int k = 2;

        Exercise189.Solution1(nums, k);
        var expected = new[] { 3,99,-1,-100 };

        nums.Should().BeEquivalentTo(expected, c => c.WithStrictOrderingFor(x => x));
    }
    
    [Test]
    public void Case3()
    {
        var nums = new [] { -1 };
        const int k = 2;

        Exercise189.Solution1(nums, k);
        var expected = new[] { -1 };

        nums.Should().BeEquivalentTo(expected, c => c.WithStrictOrderingFor(x => x));
    }
}