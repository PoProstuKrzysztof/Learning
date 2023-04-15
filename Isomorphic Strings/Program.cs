Solution solution = new Solution();

Console.WriteLine( solution.IsIsomorphic( "badc", "baba" ) );

public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s == t)
        {
            return true;
        }

        List<int> indexElements = new List<int>();
        for (int i = 0; i < s.Length; i++)
        {
            char letter = s[i];
            for (int j = i + 1; j < s.Length; j++)
            {
                if (indexElements.Count - 1 >= s.Length) break;
                if (s[j] == letter)
                {
                    if (!indexElements.Contains( i )) indexElements.Add( i );

                    if (!indexElements.Contains( j )) indexElements.Add( j );
                }
            }
        }

        if (indexElements.Count == 0) return false;

        for (int i = 0; i < indexElements.Count; i++)
        {
            if (!(t[indexElements[i]] == t[indexElements[i + 1]]))
            {
                return false;
            }
        }

        return true;
    }
}