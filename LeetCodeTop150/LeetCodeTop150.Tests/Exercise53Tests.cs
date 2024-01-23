using NUnit.Framework;

namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise53Tests
{
    [Test]
    public void Case1()
    {
        // subarray [4,-1,2,1]
        Exercise53.MaxSubArraySum(new[] { -2, 1, -3, 4, -1, 2, 1, -5 })
            .Should()
            .Be(6);
    }
    
    [Test]
    public void Case2()
    {
        // subarray [1]
        Exercise53.MaxSubArraySum(new[] { 1 })
            .Should()
            .Be(1);
    }
    
    [Test]
    public void Case3()
    {
        // subarray [5,4,-1,7,8]
        Exercise53.MaxSubArraySum(new[] { 5,4,-1,7,8 })
            .Should()
            .Be(23);
    }

    [Test]
    public void Case4()
    {
        // subarray [1]
        Exercise53.MaxSubArraySum(new[] { -2, 1 })
            .Should()
            .Be(1);
    }
}