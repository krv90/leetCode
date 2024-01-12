namespace LeetCodeTop150;

/// <summary>
/// 338. Counting Bits
/// Follow up:
/// - It is very easy to come up with a solution with a runtime of O(n log n). Can you do it in linear time O(n) and possibly in a single pass?
/// - Can you do it without using any built-in function (i.e., like __builtin_popcount in C++)?
/// </summary>
public static class Exercise338
{
    public static int[] CountBits_Simple(int n) {
        var res = new int[n + 1];
        var i = 0;
        while (i <= n)
        {
            res[i] = Convert.ToString(i, toBase: 2).Count(ch => ch == '1');
            i++;
        }

        return res;
    }
    
    public static int[] CountBits_O_n(int n) {
        var res = new int[n + 1];
        
        res[0] = 0;
        if (n >= 1) res[1] = 1;

        int iBase = 2;
        for (int i = 2; i <= n; i++)
        {
            if (i / iBase == 2) iBase *= 2; // 2: 10, 4:100, 8:1000, 16:10000 и т. д., а между ними наполение из предыдущих числел
            res[i] = 1 + res[i - iBase];
        }

        return res;
    }
}