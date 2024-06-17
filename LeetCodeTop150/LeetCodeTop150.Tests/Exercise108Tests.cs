namespace LeetCodeTop150.Tests;

[TestFixture]
public class Exercise108Tests
{
    [Test]
    public void Case1()
    {
        Exercise108
            .SortedArrayToBST(-10, -3, 0, 5, 9)
            .Should()
            .BeEquivalentTo(
                CreateBST(0, -3, 9, -10, null, 5),
                opt => opt.WithStrictOrdering()
            );
    }
    
    [Test]
    public void Case2()
    {
        Exercise108
            .SortedArrayToBST(1,3)
            .Should()
            .BeEquivalentTo(
                CreateBST(3, 1),
                opt => opt.WithStrictOrdering()
            );
    }

    private static Exercise108.TreeNode CreateBST(params int?[] arr)
    {
        var top = new Exercise108.TreeNode(arr[0].GetValueOrDefault());
        var nodes = new Queue<Exercise108.TreeNode>();
        nodes.Enqueue(top);
        
        var i = 0;
        do
        {
            var node = nodes.Dequeue();
            var left = arr.ElementAtOrDefault(++i);
            if (left != null)
            {
                node.left = new Exercise108.TreeNode(left.Value);
                nodes.Enqueue(node.left);
            }
            
            var right = arr.ElementAtOrDefault(++i);
            if (right != null)
            {
                node.right = new Exercise108.TreeNode(right.Value);
                nodes.Enqueue(node.right);
            }

        } while (i < arr.Length);

        return top;
    }
}