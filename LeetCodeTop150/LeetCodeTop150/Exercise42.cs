namespace LeetCodeTop150;

/// <summary>
/// 42. Trapping Rain Water
/// </summary>
public static class Exercise42
{
    /// <returns>
    /// Given n non-negative integers representing an elevation map where the width of each bar is 1,
    /// compute how much water it can trap after raining.
    /// </returns>
    public static int Trap(int[] height)
    {
        var result = 0;
        var start = 0;

        do
        {
            var (trapped, nextStart) = Calculate(height, start);
            result += trapped;

            start = start < nextStart 
                ? nextStart 
                : start + 1;

        } while (start < height.Length - 2 && height[start] > 0);

        return result;
    }

    private static (int trapped, int newStart) Calculate(int[] height, int start)
    {
        var startHeight = height[start];

        var endHeight = 0;
        var end = 0;
        var tempToEnd = 0;
        
        var temp = 0;
        var trapped = 0;
        
        for (int i = start; i < height.Length; i++)
        {
            if (height[i] >= startHeight)
            {
                startHeight = height[i];
                endHeight = 0;
                start = i;

                trapped += temp;
                temp = 0;
                tempToEnd = 0;
            }
            else if (startHeight > 0 && i > 0)
            {
                temp += startHeight - height[i];
            }

            if (i > start && height[i] > endHeight)
            {
                end = i;
                endHeight = height[i];
                tempToEnd = temp;
            }
        }
        
        if (tempToEnd > 0 && endHeight > 0 && startHeight > 0 && (end - start) > 1)
        {
            var overBoardVolume = (startHeight - endHeight) * (end - start);
            trapped += tempToEnd - overBoardVolume;

            return (trapped, end);
        }

        return (trapped, start + 1);
    }

    /// <summary>
    /// Более удачное решение (но хуже по памяти)
    /// </summary>
    public static int Trap2(int[] height)
    {
        // найти максимум
        var maxIndex = 0;
        for (int i = 1; i < height.Length; i++)
        {
            if (height[maxIndex] < height[i])
            {
                maxIndex = i;
            }
        }

        var trapped = 0;

        // слева до максимума
        for (int i = 0, temp = 0, startHeight = 0; i <= maxIndex; i++)
        {
            if (height[i] >= startHeight)
            {
                startHeight = height[i];

                trapped += temp;
                temp = 0;
            }
            else if (startHeight > 0 && i > 0)
            {
                temp += startHeight - height[i];
            }
        }
        
        // справа до максимума
        for (int i = height.Length -1, temp = 0, startHeight = 0; i >= maxIndex; i--)
        {
            if (height[i] >= startHeight)
            {
                startHeight = height[i];

                trapped += temp;
                temp = 0;
            }
            else if (startHeight > 0 && i > 0)
            {
                temp += startHeight - height[i];
            }
        }

        return trapped;
    }
}