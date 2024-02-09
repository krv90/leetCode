namespace LeetCodeTop150;

/// <summary>
/// 637. Average of Levels in Binary Tree
/// </summary>
public static class Exercise637
{
    public static IList<double> AverageOfLevels(TreeNode root) {
        /* по условию всегда есть
        if (root == null)
        {
            return new List<double>(0);
        }
        */
        
        // более лаконичную реализацию (без рекурсии) можно сделать с применением очереди

        var levelMap = new Dictionary<int, LevelSummary>();
        CalcToLevelSummary(root, levelMap, 1);

        return levelMap.Values.Select(s => s.Sum / s.Count).ToArray();
    }

    private static void CalcToLevelSummary(TreeNode node, Dictionary<int, LevelSummary> levelMap, int level)
    {
        if (node == null)
        {
            return;
        }

        var summary = levelMap.GetValueOrDefault(level);
        summary += new LevelSummary(node);
        levelMap[level] = summary;
        
        CalcToLevelSummary(node.left, levelMap, level + 1);
        CalcToLevelSummary(node.right, levelMap, level + 1);
    }

    private struct LevelSummary
    {
        public LevelSummary(TreeNode node)
        {
            Sum = node.val;
            Count = 1;
        }
        public double Sum { get; set; }
        public double Count { get; set; }
        public static LevelSummary operator +(LevelSummary a, LevelSummary b) => new LevelSummary { Sum = a.Sum + b.Sum, Count = a.Count + b.Count };
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}