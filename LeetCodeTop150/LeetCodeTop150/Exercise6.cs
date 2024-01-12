using System.Text;

namespace LeetCodeTop150;

/// <summary>
/// 6. Zigzag Conversion
/// </summary>
public static class Exercise6
{
    public static string Convert(string s, int numRows)
    {
        if (numRows <= 1|| s.Length <= numRows)
        {
            return s;
        }
        
        var res = new char[s.Length];
        
        const char noSymbol = '\0';
        var symbols = new char[numRows, s.Length - numRows + 1];

        var row = 0;
        var col = 0;

        var step = 1;
        var incrementCol = false;

        for (var index = 0; index < s.Length; index++)
        {
            symbols[row, col] = s[index];

            if (row == numRows - 1)
            {
                step = -1;
                incrementCol = true;
            }
            else if (row == 0)
            {
                step = 1;
                incrementCol = false;
            }

            row += step;
            if (incrementCol)
            {
                col++;
            }
        }

        var ri = 0;
        for (col = 0; col < numRows; col++)
        {
            for (row = 0; row <= s.Length - numRows; row++)
            {
                var symbol = symbols[col, row];
                if (symbol != noSymbol)
                {
                    res[ri] = symbol;
                    ri++;
                }
            }
        }

        return new string(res);
    }
    
    public static string Convert2(string s, int numRows)
    {
        if (numRows <= 1 || s.Length <= numRows)
        {
            return s;
        }
        
        var substrings = new StringBuilder[numRows];

        var row = 0;
        var step = 1;

        foreach (var sChar in s)
        {
            var builder = substrings[row];
            if (builder == null)
            {
                builder = new StringBuilder();
                substrings[row] = builder;
            }
            
            builder.Append(sChar);

            if (row == numRows - 1)
            {
                step = -1;
            }
            else if (row == 0)
            {
                step = 1;
            }

            row += step;
        }

        for (var i = 1; i < numRows; i++)
        {
            substrings[0].Append(substrings[i]);
        }

        return substrings[0].ToString();
    }
}