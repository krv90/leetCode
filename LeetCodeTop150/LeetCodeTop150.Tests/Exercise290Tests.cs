namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise290Tests
{
    [Test]
    public void Case1()
    {
        var pattern = "abba";
        var s = "dog cat cat dog";

        Exercise290.WordPattern(pattern, s).Should().Be(true);
    }
    
    [Test]
    public void Case2()
    {
        var pattern = "abba";
        var s = "dog cat cat fish";

        Exercise290.WordPattern(pattern, s).Should().Be(false);
    }
    
    [Test]
    public void Case3()
    {
        var pattern = "aaaa";
        var s = "dog cat cat dog";

        Exercise290.WordPattern(pattern, s).Should().Be(false);
    }
    
    [Test]
    public void Case4()
    {
        var pattern = "abba";
        var s = "dog dog dog dog";

        Exercise290.WordPattern(pattern, s).Should().Be(false);
    }
    
    [Test]
    public void Case5()
    {
        var pattern = "jquery";
        var s = "jquery";

        Exercise290.WordPattern(pattern, s).Should().Be(false);
    }
}