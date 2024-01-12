namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise27Tests
{
    [Test]
    public void Case1()
    {
        int[] nums = { 3, 2, 2, 3 };
        const int val = 3;

        var actual = Exercise27.RemoveElement(nums, val);
        var expected = new[] { 2, 2 };

        nums.Should().StartWith(expected);
        actual.Should().Be(2);
    }
    
    [Test]
    public void Case2()
    {
        int[] nums = { 0,1,2,2,3,0,4,2 };
        const int val = 2;

        var actual = Exercise27.RemoveElement(nums, val);
        var expected = new[] { 0,1,3,0,4 };

        nums.Should().StartWith(expected);
        actual.Should().Be(5);
    }
    
    [Test]
    public void Case3()
    {
        int[] nums = { 1 };
        const int val = 1;

        var actual = Exercise27.RemoveElement(nums, val);
        var expected = new[] { -1 };

        nums.Should().StartWith(expected);
        actual.Should().Be(0);
    }
    
    [Test]
    public void Case4()
    {
        int[] nums = { 1 };
        const int val = 0;

        var actual = Exercise27.RemoveElement(nums, val);
        var expected = new[] { 1 };

        nums.Should().StartWith(expected);
        actual.Should().Be(1);
    }
}