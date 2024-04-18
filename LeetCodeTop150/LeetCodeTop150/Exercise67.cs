using System.Text;

namespace LeetCodeTop150;

/// <summary>
/// 67. Add Binary
/// </summary>
public static class Exercise67
{
    public static string AddBinary(string a, string b)
    {
        /*
         var res = Convert.ToInt32(a, 2) + Convert.ToInt32(b, 2);
         return Convert.ToString(res, 2);
         */
        var builder = new StringBuilder(Math.Max(a.Length, b.Length) + 1);

        var indexA = a.Length - 1;
        var indexB = b.Length - 1;
        var plus1 = false;

        while (indexA >= 0 || indexB >= 0)
        {
            var ai = indexA >= 0 && a[indexA] == '1';
            indexA--;

            var bi = indexB >= 0 && b[indexB] == '1';
            indexB--;

            var resChar = ai ^ bi ^ plus1 ? '1' : '0';
            builder.Insert(0, resChar);
            
            plus1 = ai & bi || (ai | bi) & plus1;
        }

        if (plus1)
        {
            builder.Insert(0, '1');
        }

        return builder.ToString();
    }
}