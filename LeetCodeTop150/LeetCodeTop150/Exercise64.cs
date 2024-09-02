namespace LeetCodeTop150;

/// <summary>
/// 64. Minimum Path Sum
/// </summary>
/// <remarks>
///
/// Given a m x n grid filled with non-negative numbers, find a path from top left to bottom right, which minimizes the sum of all numbers along its path.
/// Note: You can only move either down or right at any point in time. !!! ВАЖНО !!!
/// </remarks>
public static class Exercise64
{
    public static int MinPathSum(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;
        var dp = new int[grid.Length][];

        for (var i = 0; i < m; i++)
        {
            dp[i] = new int[n];

            for (var j = 0; j < grid[i].Length; j++)
            {
                if (i == 0 && j == 0)
                {
                    dp[i][j] = grid[i][j];
                    continue;
                }

                var fromTop = i > 0 ? dp[i - 1][j] : int.MaxValue; 
                var fromLeft = j > 0 ? dp[i][j - 1] : int.MaxValue; 
                
                dp[i][j] = grid[i][j] + Math.Min(fromTop, fromLeft);
            }
        }
        
        return dp[m - 1][n - 1];
    }
}