namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise1846Tests
{
    [Test]
    public void Case1()
    {
        var arr = new[] { 2,2,1,2,1 };

        var actual = Exercise1846.MaximumElementAfterDecrementingAndRearranging(arr);

        var expected = 2;
        var expectedArr = new[] { 1, 2, 2, 2, 1 };

        actual.Should().Be(expected);
        arr.Should().BeEquivalentTo(expectedArr, opt => opt.WithoutStrictOrderingFor(i => i));
    }
    
    [Test]
    public void Case2()
    {
        var arr = new[] { 100, 1 ,1000 };

        var actual = Exercise1846.MaximumElementAfterDecrementingAndRearranging(arr);

        var expected = 3;
        var expectedArr = new[] { 1,2,3 };

        actual.Should().Be(expected);
        arr.Should().BeEquivalentTo(expectedArr, opt => opt.WithoutStrictOrderingFor(i => i));
    }
    
    [Test]
    public void Case3()
    {
        var arr = new[] { 1,2,3,4,5 };

        var actual = Exercise1846.MaximumElementAfterDecrementingAndRearranging(arr);

        var expected = 5;
        var expectedArr = new[] { 1,2,3, 4, 5 };

        actual.Should().Be(expected);
        arr.Should().BeEquivalentTo(expectedArr, opt => opt.WithoutStrictOrderingFor(i => i));
    }
}