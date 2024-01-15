using NUnit.Framework;

namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise79Tests
{
    [Test]
    public void Case1()
    {
        var board = new[]
        {
            new[] { 'A', 'B', 'C', 'E' },
            new[] { 'S', 'F', 'C', 'S' },
            new[] { 'A', 'D', 'E', 'E' }
        };

        Exercise79.Exist(board, "ABCCED").Should().Be(true);
    }
    
    [Test]
    public void Case2()
    {
        var board = new[]
        {
            new[] { 'A', 'B', 'C', 'E' },
            new[] { 'S', 'F', 'C', 'S' },
            new[] { 'A', 'D', 'E', 'E' }
        };

        Exercise79.Exist(board, "SEE").Should().Be(true);
    }
    
    [Test]
    public void Case3()
    {
        var board = new[]
        {
            new[] { 'A', 'B', 'C', 'E' },
            new[] { 'S', 'F', 'C', 'S' },
            new[] { 'A', 'D', 'E', 'E' }
        };

        Exercise79.Exist(board, "ABCB").Should().Be(false);
    }
    
    [Test]
    public void Case4()
    {
        var board = new[]
        {
            new[] { 'A', 'B', 'C', 'E' },
            new[] { 'S', 'F', 'C', 'S' },
            new[] { 'A', 'D', 'E', 'E' }
        };

        Exercise79.Exist(board, "F").Should().Be(true);
    }
    
    [Test]
    public void Case5()
    {
        var board = new[]
        {
            new[] { 'A', 'B', 'C', 'E' },
            new[] { 'S', 'F', 'C', 'S' },
            new[] { 'A', 'D', 'E', 'E' }
        };

        Exercise79.Exist(board, "FCEDF").Should().Be(false);
    }
    
    [Test]
    public void Case6()
    {
        var board = new[]
        {
            new[] { 'a', 'a' },
        };

        Exercise79.Exist(board, "aa").Should().Be(true);
    }
    
    [Test]
    public void Case7()
    {
        var board = new[]
        {
            new[] { 'a', 'a' },
        };

        Exercise79.Exist(board, "aaa").Should().Be(false);
    }
}