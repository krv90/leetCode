namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise1980Tests
{
    [TestCase("0", "1")]
    [TestCase("1", "0")]
    public void Case0(string source, string expected)
    {
        var nums = new[] { source };

        var actual = Exercise1980.FindDifferentBinaryString(nums);

        actual.Should().Be(expected);
    }

    [Test]
    public void Case1()
    {
        var nums = new[] { "01", "10" };

        var actual = Exercise1980.FindDifferentBinaryString(nums);
        var expecteds = new[] { "00", "11" };

        expecteds.Should().Contain(actual);
    }

    [Test]
    public void Case2()
    {
        var nums = new[] { "00","01" };

        var actual = Exercise1980.FindDifferentBinaryString(nums);
        var expecteds = new[] { "10", "11" };

        expecteds.Should().Contain(actual);
    }

    [Test]
    public void Case3()
    {
        var nums = new[] { "111","011","001" };

        var actual = Exercise1980.FindDifferentBinaryString(nums);
        var expecteds = new[] { "000", "010", "100", "110" };

        expecteds.Should().Contain(actual);
    }
}