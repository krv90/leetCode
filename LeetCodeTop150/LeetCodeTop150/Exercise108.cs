namespace LeetCodeTop150;

/// <summary>
/// 108. Convert Sorted Array to Binary Search Tree
/// </summary>
/// <remarks>
/// Given an integer array nums where the elements are sorted in ascending order, convert it to a height-balanced binary search tree.
/// </remarks>
public class Exercise108
{
    public static TreeNode SortedArrayToBST(params int[] nums)
    {
        return GetMiddle(nums);
    }

    private static TreeNode GetMiddle(int[] nums)
    {
        if (nums.Length == 0)
        {
            return null;
        }
        
        if (nums.Length == 1)
        {
            return new TreeNode(nums[0]);
        }
        
        var middleIndex = nums.Length / 2;
        var treeNode = new TreeNode(nums[middleIndex])
        {
            left = GetMiddle(nums.Skip(0).Take(middleIndex).ToArray()),
            right = GetMiddle(nums.Skip(middleIndex + 1).Take(middleIndex).ToArray())
        };

        return treeNode;
    }

    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}


