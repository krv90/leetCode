namespace LeetCodeTop150;

/// <summary>
/// 79. Word Search
/// </summary>
public static class Exercise79
{
    public static bool Exist_Slow(char[][] board, string word)
    {
        var charPoints = new List<(int, int)[]>();

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                if (board[i][j] == word[0])
                {
                    charPoints.Add(new (int, int)[] { (i, j) });
                }
            }
        }

        if (charPoints.Any() && word.Length == 1)
            return true;


        while (charPoints.Any())
        {
            
            for (int i = charPoints[0].Length; i < word.Length; i++)
            {
                var charPoint = charPoints[0];
                charPoints.Remove(charPoint);
                
                (int xi, int yi) = charPoint[^1];
                var nextVariants = new[]
                {
                    (xi - 1, yi),
                    (xi + 1, yi),
                    (xi, yi - 1),
                    (xi, yi + 1)
                };

                var existsNewVariants = false;
                foreach (var (x, y) in nextVariants)
                {
                    if (
                        !(0 <= x && x < board.Length) ||
                        !(0 <= y && y < board[x].Length) ||
                        board[x][y] != word[i] ||
                        charPoint.Contains((x, y))
                    )
                    {
                        continue;
                    }
                    
                    if (i == word.Length - 1)
                    {
                        return true;
                    }

                    var newCharChain = new (int, int)[i + 1];
                    charPoint.CopyTo(newCharChain, 0);
                    newCharChain[^1] = (x, y);
                    
                    charPoints.Insert(0, newCharChain);
                    existsNewVariants = true;
                }

                if (!existsNewVariants)
                {
                    break;
                }
            }
        }

        return false;
    }
    
    public static bool Exist(char[][] board, string word)
    {
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                if (board[i][j] == word[0])
                {
                    if (RecursivelyExists(i, j, board, word, 1))
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }

    private static bool RecursivelyExists(int i, int j, char[][] board, string word, int count)
    {
        if (count == word.Length) return true;

        var currChar = board[i][j];
        board[i][j] = '-'; // убираем символ на время (восстановим в случае неудасного выполнения)
        var nextChar = word[count];

        //up
        if (i > 0 && board[i - 1][j] == nextChar)
        {
            if (RecursivelyExists(i - 1, j, board, word, count + 1)) return true;
        }

        //down
        if (i < board.Length - 1 && board[i + 1][j] == nextChar)
        {
            if (RecursivelyExists(i + 1, j, board, word, count + 1)) return true;
        }

        //left
        if (j > 0 && board[i][j - 1] == nextChar)
        {
            if (RecursivelyExists(i, j - 1, board, word, count + 1)) return true;
        }

        //right
        if (j < board[0].Length - 1 && board[i][j + 1] == nextChar)
        {
            if (RecursivelyExists(i, j + 1, board, word, count + 1)) return true;
        }

        board[i][j] = currChar;
        return false;
    }
}