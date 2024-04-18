namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise67Tests
{
    [Test]
    [TestCase("11", "1", "100")]
    [TestCase("1010", "1011", "10101")]
    [TestCase("111", "1111", "10110")]
    [TestCase("0", "0", "0")]
    public void Cases(string a, string b, string expected)
    {
        Exercise67.AddBinary(a, b).Should().Be(expected);
    }

    [Test]
    public void NoExceptionCase()
    {
        var action = () => Exercise67.AddBinary(
            "10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101",
            "110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011"
        );

        action.Should().NotThrow();
    }
}