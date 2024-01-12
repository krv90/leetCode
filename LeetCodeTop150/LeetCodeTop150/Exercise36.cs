namespace LeetCodeTop150;

public static class Exercise36
{
    public static bool IsValidSudoku(char[][] board)
    {
        const char noVal = '.';
        const int row = 0;
        const int col = 10;
        const int box = 100;

        var map = new Dictionary<char, HashSet<int>>();

        for (var i = 0; i < board.Length; i++)
        {
            for (var j = 0; j < board[i].Length; j++)
            {
                var curVal = board[i][j];
                if (curVal == noVal)
                {
                    continue;
                }

                var valMap = map.GetValueOrDefault(curVal);
                if (valMap == null)
                {
                    valMap = new HashSet<int>();
                    map.Add(curVal, valMap);
                }

                if (!valMap.Add(row + i))
                {
                    return false;
                }
                
                if (!valMap.Add(col + j))
                {
                    return false;
                }

                var curBox = (i / 3) + (j / 3) * col + box;
                if (!valMap.Add(curBox))
                {
                    return false;
                }
            }
        }

        return true;
    }
}