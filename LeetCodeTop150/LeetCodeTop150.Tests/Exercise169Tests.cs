namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise169Tests
{
    [Test]
    public void Case1()
    {
        var nums = new [] { 3, 2, 3 };

        var actual = Exercise169.MajorityElement(nums);

        actual.Should().Be(3);
    }
    
    [Test]
    public void Case2()
    {
        var nums = new [] { 2,2,1,1,1,2,2 };

        var actual = Exercise169.MajorityElement(nums);

        actual.Should().Be(2);
    }
}