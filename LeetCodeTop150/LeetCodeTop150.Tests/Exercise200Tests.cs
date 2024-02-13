namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise200Tests
{
    [Test]
    public void Case1()
    {
        var grid = new char[][]
        {
            new[] { '1', '1', '1', '1', '0' },
            new[] { '1', '1', '0', '1', '0' },
            new[] { '1', '1', '0', '0', '0' },
            new[] { '0', '0', '0', '0', '0' }
        };

        Exercise200.NumIslands(grid).Should().Be(1);
    }
    
    [Test]
    public void Case2()
    {
        var grid = new char[][]
        {
            new[] { '1', '1', '0', '0', '0' },
            new[] { '1', '1', '0', '0', '0' },
            new[] { '0', '0', '1', '0', '0' },
            new[] { '0', '0', '0', '1', '1' }
        };

        Exercise200.NumIslands(grid).Should().Be(3);
    }
    
    [Test]
    public void Case3()
    {
        var grid = new char[][]
        {
            new[] { '0', '0', '0', '0', '0' },
            new[] { '0', '1', '1', '1', '0' },
            new[] { '0', '1', '1', '1', '0' },
            new[] { '0', '1', '1', '1', '0' },
            new[] { '0', '0', '0', '0', '0' }
        };

        Exercise200.NumIslands(grid).Should().Be(1);
    }
    
    [Test]
    public void Case4()
    {
        var grid = new char[][]
        {
            new[] { '0', '1', '1', '0', '0' },
            new[] { '0', '0', '1', '1', '0' },
            new[] { '0', '0', '0', '1', '0' },
            new[] { '1', '0', '0', '1', '0' },
            new[] { '0', '1', '1', '1', '0' }
        };

        Exercise200.NumIslands(grid).Should().Be(2);
    }
}