namespace LeetCodeTop150;

/// <summary>
/// 20. Valid Parentheses
/// </summary>
public static class Exercise20
{
    public static bool IsValid(string s)
    {
        var stack = new Stack<char>();

        bool IsCloseExpectedBracket(char expected)
        {
            stack.TryPop(out var actual);
            return actual == expected;
        }

        foreach (var ch in s)
        {
            switch (ch)
            {
                case '(':
                case '[':
                case '{':
                    stack.Push(ch);
                    continue;
                case ')':
                    if (!IsCloseExpectedBracket('('))
                        return false;
                    continue;
                case ']':
                    if (!IsCloseExpectedBracket('['))
                        return false;
                    continue;
                case '}':
                    if (!IsCloseExpectedBracket('{'))
                        return false;
                    continue;
                default:
                    return false;
            }
        }

        return stack.Count == 0;
    }
    

    public static bool IsValid2(string s)
    {
        if (s == null || int.IsOddInteger(s.Length))
            return false;

        var stack = new Stack<char>();
        foreach (var ch in s)
        {
            switch (ch)
            {
                case '(':
                    stack.Push(')');
                    continue;
                case '[':
                    stack.Push(']');
                    continue;
                case '{':
                    stack.Push('}');
                    continue;
                case ')':
                case ']':
                case '}':
                    stack.TryPop(out var actual);
                    if (actual != ch)
                        return false;
                    continue;
                default:
                    return false;
            }
        }

        return stack.Count == 0;
    }
}