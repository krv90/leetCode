using NUnit.Framework;

namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise643Tests
{
    [Test]
    public void Case1()
    {
        var nums = new int[] { 1, 12, -5, -6, 50, 3 };
        const int k = 4;

        Exercise643.FindMaxAverage(nums, k).Should().Be(12.75);
    }
    
    [Test]
    public void Case2()
    {
        var nums = new int[] { 5 };
        const int k = 1;

        Exercise643.FindMaxAverage(nums, k).Should().Be(5);
    }
    
    [Test]
    public void Case3()
    {
        var nums = new int[] { 0,4,0,3,2 };
        const int k = 1;

        Exercise643.FindMaxAverage(nums, k).Should().Be(4);
    }
}