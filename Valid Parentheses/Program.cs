Console.WriteLine( "Should be false: " + Solution.IsValid( "(])" ) );
Console.WriteLine( "Should be true: " + Solution.IsValid( "()" ) );
Console.WriteLine( "Should be true: " + Solution.IsValid( "()[]{}" ) );
Console.WriteLine( "Should be true: " + Solution.IsValid( "{[]}" ) );

public static class Solution
{
    public static bool IsValid(string s)
    {
        Stack<int> stack = new Stack<int>();
        foreach (var c in s)
        {
            if (c == '[' || c == '{' || c == '(')
            {
                stack.Push( c );
            }
            else
            {
                if (stack.Count == 0) return false;
                else if (c == '}' && stack.Peek() == '{') { stack.Pop(); }
                else if (c == ']' && stack.Peek() == '[') { stack.Pop(); }
                else if (c == ')' && stack.Peek() == '(') { stack.Pop(); }
                else
                {
                    return false;
                }
            }
        }
        GC.Collect();
        return stack.Count == 0 ? true : false;
    }
}