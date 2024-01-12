namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise26Tests
{
    [Test]
    public void Case1()
    {
        var nums = new[] { 1, 1, 2 };

        var actual = Exercise26.RemoveDuplicates(nums);
        var expected = new[] { 1, 2 };

        actual.Should().Be(2);
        nums.Should().StartWith(expected);
    }
    
    [Test]
    public void Case2()
    {
        var nums = new[] { 0,0,1,1,1,2,2,3,3,4 };

        var actual = Exercise26.RemoveDuplicates(nums);
        var expected = new[] { 0, 1, 2, 3, 4 };

        actual.Should().Be(5);
        nums.Should().StartWith(expected);
    }
    
    [Test]
    public void Case3()
    {
        var nums = new[] { 1, 1 };

        var actual = Exercise26.RemoveDuplicates(nums);
        var expected = new[] { 1 };

        actual.Should().Be(1);
        nums.Should().StartWith(expected);
    }
}