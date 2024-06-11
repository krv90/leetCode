namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise1732Tests
{
    [Test]
    public void Case1()
    {
        Exercise1732.LargestAltitude(new[] { -5, 1, 5, 0, -7 }).Should().Be(1);
    }
    
    [Test]
    public void Case2()
    {
        Exercise1732.LargestAltitude(new[] { -4, -3, -2, -1, 4, 3, 2 }).Should().Be(0);
    }
}