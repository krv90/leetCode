namespace LeetCodeTop150;

/// <summary>
/// 200. Number of Islands
/// </summary>
public static class Exercise200
{
    public static int NumIslands(char[][] grid)
    {
        /* по условиям задачи всегда непустой
        if (grid.Length == 0)
        {
            return 0;
        }
        */
        
        var result = 0;
        bool [,] visited = new bool[grid.Length, grid[0].Length];

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (visited[i, j])
                {
                    continue;
                }
                
                result += DetectIsland(grid, i, j, visited);
            }
        }

        return result;
    }

    private static int DetectIsland(char[][] grid, int i, int j, bool[,] visited)
    {
        var isValid = 0 <= i && i < grid.Length
            && 0 <= j && j < grid[i].Length
            && !visited[i, j];
        
        if (!isValid)
        {
            return 0;
        }

        visited[i, j] = true;
        if (grid[i][j] == '0')
        {
            return 0;
        }

        DetectIsland(grid, i + 1, j, visited);
        DetectIsland(grid, i - 1, j, visited);
        DetectIsland(grid, i, j + 1, visited);
        DetectIsland(grid, i, j - 1, visited);
        
        return 1;
    }
}