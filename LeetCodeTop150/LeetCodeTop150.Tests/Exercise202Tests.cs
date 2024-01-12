namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise202Tests
{
    [Test]
    public void Case1()
    {
        Exercise202.IsHappy(19).Should().BeTrue();
    }
    
    [Test]
    public void Case2()
    {
        Exercise202.IsHappy(2).Should().BeFalse();
    }
    
    [Test]
    public void Case3()
    {
        Exercise202.IsHappy(7).Should().BeTrue();
    }
    
    [Test]
    public void Case4()
    {
        Exercise202.IsHappy(11).Should().BeFalse();
    }
}