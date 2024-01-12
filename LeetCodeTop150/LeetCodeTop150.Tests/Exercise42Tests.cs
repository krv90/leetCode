namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise42Tests
{
    [Test]
    public void Case1()
    {
        var height = new[] { 0,1,0,2,1,0,1,3,2,1,2,1 };

        var actual = Exercise42.Trap(height);

        actual.Should().Be(6);
    }

    [Test]
    public void Case2()
    {
        var height = new[] { 4, 2, 0, 3, 2, 5 };

        var actual = Exercise42.Trap(height);

        actual.Should().Be(9);
    }

    [Test]
    public void Case3()
    {
        var height = new[] { 2, 1, 0, 1 };

        var actual = Exercise42.Trap(height);

        actual.Should().Be(1);
    }

    [Test]
    public void Case4()
    {
        var height = new[] { 4, 2, 3 };

        var actual = Exercise42.Trap(height);

        actual.Should().Be(1);
    }

    [Test]
    public void Case5()
    {
        var height = new[] { 5, 4, 1, 2 };

        var actual = Exercise42.Trap(height);

        actual.Should().Be(1);
    }

    [Test]
    public void Case6()
    {
        var height = new[] { 0,1,2,0,3,0,1,2,0,0,4,2,1,2,5,0,1,2,0,2 };

        var actual = Exercise42.Trap(height);

        actual.Should().Be(26);
    }
}