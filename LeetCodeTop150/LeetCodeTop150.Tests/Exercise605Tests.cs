namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise605Tests
{
    [Test]
    [TestCase(1, true)]
    [TestCase(2, false)]
    public void Case_1_and_2(int n, bool expected)
    {
        Exercise605
            .CanPlaceFlowers(new[] { 1, 0, 0, 0, 1 }, n)
            .Should()
            .Be(expected);
    }
    
    [Test]
    [TestCase(0, true)]
    [TestCase(1, false)]
    public void Case_3_4(int val, bool expected)
    {
        Exercise605
            .CanPlaceFlowers(new[] { val }, 1)
            .Should()
            .Be(expected);
    }
    
    [Test]
    public void Case_5()
    {
        Exercise605
            .CanPlaceFlowers(new[] { 0, 0, 1 }, 1)
            .Should()
            .Be(true);
    }
    
    [Test]
    public void Case_6()
    {
        Exercise605
            .CanPlaceFlowers(new[] { 1, 0, 0 }, 1)
            .Should()
            .Be(true);
    }
    
    [Test]
    public void Case_7()
    {
        Exercise605
            .CanPlaceFlowers(new[] { 1, 0, 1, 0, 1 }, 1)
            .Should()
            .Be(false);
    }
}