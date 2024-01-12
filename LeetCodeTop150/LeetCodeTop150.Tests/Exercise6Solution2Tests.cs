namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise6Solution2Tests
{
    [Test]
    public void Case1()
    {
        var s = "PAYPALISHIRING";
        var numRows = 3;

        var actual = Exercise6.Convert2(s, numRows);

        actual.Should().Be("PAHNAPLSIIGYIR");
    }

    [Test]
    public void Case2()
    {
        var s = "PAYPALISHIRING";
        var numRows = 4;

        var actual = Exercise6.Convert2(s, numRows);

        actual.Should().Be("PINALSIGYAHRPI");
    }

    [Test]
    public void Case3()
    {
        var s = "A";
        var numRows = 1;

        var actual = Exercise6.Convert2(s, numRows);

        actual.Should().Be("A");
    }

    [Test]
    public void Case4()
    {
        var s = "ABC";
        var numRows = 2;

        var actual = Exercise6.Convert2(s, numRows);

        actual.Should().Be("ACB");
    }

    [Test]
    public void Case5()
    {
        var s = "A";
        var numRows = 2;

        var actual = Exercise6.Convert2(s, numRows);

        actual.Should().Be("A");
    }

    [Test]
    public void Case6()
    {
        var s = "AB";
        var numRows = 3;

        var actual = Exercise6.Convert2(s, numRows);

        actual.Should().Be("AB");
    }
}