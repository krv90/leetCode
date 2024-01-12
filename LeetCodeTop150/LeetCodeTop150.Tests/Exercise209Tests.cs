using NUnit.Framework;

namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise209Tests
{
    [Test]
    public void Case1()
    {
        var target = 7;
        var nums = new int [] {2,3,1,2,4,3};

        Exercise209.MinSubArrayLen(target, nums).Should().Be(2);
    }
    
    [Test]
    public void Case2()
    {
        var target = 4;
        var nums = new int [] {1, 4, 4};

        Exercise209.MinSubArrayLen(target, nums).Should().Be(1);
    }
    
    [Test]
    public void Case3()
    {
        var target = 11;
        var nums = new int [] {1,1,1,1,1,1,1,1};

        Exercise209.MinSubArrayLen(target, nums).Should().Be(0);
    }
    
    [Test]
    public void Case4()
    {
        var target = 5;
        var nums = new int [] {1,2,3,4,5};

        Exercise209.MinSubArrayLen(target, nums).Should().Be(1);
    }
    
    [Test]
    public void Case5()
    {
        var target = 11;
        var nums = new int [] {1,2,3,4,5};

        Exercise209.MinSubArrayLen(target, nums).Should().Be(3);
    }
    
    [Test]
    public void Case6()
    {
        var target = 15;
        var nums = new int [] {5,1,3,5,10,7,4,9,2,8};

        Exercise209.MinSubArrayLen(target, nums).Should().Be(2);
    }
}