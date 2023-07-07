using System.Text;

//Console.WriteLine( "Should be -1: " + Solution.StrStr( "aaa", "aaaa" ) );
Console.WriteLine("Should be -1: " + Solution.StrStr("leetcode", "leeto"));
Console.WriteLine("Should be 0: " + Solution.StrStr("a", "a"));
Console.WriteLine("Should be -4: " + Solution.StrStr("mississippi", "issip"));

public static class Solution
{
    public static int StrStr(string haystack, string needle)
    {
        if (needle.Length > haystack.Length) return -1;

        for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
        {
            if (needle[0] != haystack[i]) continue;
            else if (needle.Length == 1) return i;

            for (int j = i + 1; j < i + needle.Length; j++)
            {
                if (needle[j - i] != haystack[j]) break;
                else if (j == i + needle.Length - 1) return i;
            }
        }

        return -1;
    }
}