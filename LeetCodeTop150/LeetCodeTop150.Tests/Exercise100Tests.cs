using NUnit.Framework;

namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise100Tests
{
    [Test]
    public void Case1()
    {
        var p = CreateNode(1, 2, 3);
        var q = CreateNode(1, 2, 3);

        Exercise100.IsSameTree(p, q).Should().Be(true);
    }
    
    [Test]
    public void Case2()
    {
        var p = CreateNode(1, 2);
        var q = CreateNode(1, null, 2);

        Exercise100.IsSameTree(p, q).Should().Be(false);
    }
    
    [Test]
    public void Case3()
    {
        var p = CreateNode(1, 2, 1);
        var q = CreateNode(1, 1, 2);

        Exercise100.IsSameTree(p, q).Should().Be(false);
    }
    
    [Test]
    public void Case4()
    {
        var p = CreateNode(10, 5, 15);
        var q = CreateNode(10, 5, null);
        q.left = CreateNode(5, null, 15);

        Exercise100.IsSameTree(p, q).Should().Be(false);
    }

    private static Exercise100.TreeNode CreateNode(params int?[] values)
    {
        var start = values.First();
        var result = new Exercise100.TreeNode(start!.Value);

        for (var i = 1; i < values.Length; i++)
        {
            var nextNode = values[i] == null ? null : new Exercise100.TreeNode(values[i].Value);
            if (int.IsOddInteger(i))
            {
                result.left = nextNode;
            }
            else
            {
                result.right = nextNode;
            }
        }

        return result;
    }
}