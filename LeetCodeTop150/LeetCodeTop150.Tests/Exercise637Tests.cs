using NUnit.Framework;

namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise637Tests
{
    [Test]
    public void Case1()
    {
        var root = new Exercise637.TreeNode(3)
        {
            left = new Exercise637.TreeNode(9),
            right = new Exercise637.TreeNode(20)
            {
                left = new Exercise637.TreeNode(15),
                right = new Exercise637.TreeNode(7)
            }
        };

        Exercise637.AverageOfLevels(root).Should().BeEquivalentTo(new[] { 3.00000, 14.50000, 11.00000 });
    }
    
    [Test]
    public void Case2()
    {
        var root = new Exercise637.TreeNode(3)
        {
            left = new Exercise637.TreeNode(9)
            {
                left = new Exercise637.TreeNode(15),
                right = new Exercise637.TreeNode(7)
            },
            right = new Exercise637.TreeNode(20)
        };
        Exercise637.AverageOfLevels(root).Should().BeEquivalentTo(new[] { 3.00000, 14.50000, 11.00000 });
    }
}