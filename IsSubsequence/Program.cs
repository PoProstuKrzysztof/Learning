﻿using System.Text;

Solution test = new Solution();
Console.WriteLine( test.IsSubsequence( "", "ahbgdc" ) );

public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if (s.Length == 0) return true;
        if (s.Length > t.Length) return false;
        StringBuilder first = new StringBuilder();
        for (int i = 0, j = 0; i < t.Length && j < s.Length; i++)
        {
            if (t[i] == s[j])
            {
                first.Append( t[i] );
                j++;
            }
        }

        if (first.ToString() == s)
            return true;

        return false;
    }
}