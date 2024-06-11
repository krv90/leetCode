namespace LeetCodeTop150;

/// <summary>
/// 1732. Find the Highest Altitude
/// </summary>
public static class Exercise1732
{
    public static int LargestAltitude(int[] gain) {
        var max = 0;
        var current = 0;
        foreach(var i in gain){
            current += i;
            if (max < current){
                max = current;
            }
        }

        return max;
    }
}