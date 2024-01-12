namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise228Tests
{
    [Test]
    public void Case1()
    {
        var nums = new[] { 0, 1, 2, 4, 5, 7 };

        var actual = Exercise228.SummaryRanges(nums);
        var expected = new[] { "0->2", "4->5", "7" };

        actual.Should().BeEquivalentTo(expected);
    }

    [Test]
    public void Case2()
    {
        var nums = new[] { 0,2,3,4,6,8,9 };

        var actual = Exercise228.SummaryRanges(nums);
        var expected = new[] { "0","2->4","6","8->9" };

        actual.Should().BeEquivalentTo(expected);
    }
}