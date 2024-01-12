namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise125Tests
{
    [Test]
    public void Case1()
    {
        Exercise125
            .IsPalindrome("A man, a plan, a canal: Panama")
            .Should()
            .BeTrue();
    }
    
    [Test]
    public void Case2()
    {
        Exercise125.IsPalindrome("race a car")
            .Should()
            .BeFalse();
    }
    
    [Test]
    public void Case3()
    {
        Exercise125.IsPalindrome(" ")
            .Should()
            .BeTrue();
    }
    
    [Test]
    public void Case4()
    {
        Exercise125.IsPalindrome("Аргентина манит негра")
            .Should()
            .BeTrue();
    }
    
    [Test]
    public void Case5()
    {
        Exercise125.IsPalindrome("казак")
            .Should()
            .BeTrue();
    }
    
    [Test]
    public void Case6()
    {
        Exercise125.IsPalindrome(".,")
            .Should()
            .BeTrue();
    }

    [Test]
    public void Case7()
    {
        Exercise125.IsPalindrome("0P")
            .Should()
            .BeFalse();
    }
}