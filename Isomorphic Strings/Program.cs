Solution solution = new Solution();

Console.WriteLine( solution.IsIsomorphic( "paper", "title" ) );

public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        int[] m1 = new int[256];
        int[] m2 = new int[256];
        int n = s.Length;

        for (int i = 0; i < n; ++i)
        {
            if (m1[s[i]] != m2[t[i]])
            {
                return false;
            }
            m1[s[i]] = i + 1;
            m2[t[i]] = i + 1;
        }
        return true;

        //dictonary.

        //List<int> indexElements = new List<int>();
        //for (int i = 0; i < s.Length; i++)
        //{
        //    char letter = s[i];
        //    for (int j = i + 1; j < s.Length; j++)
        //    {
        //        if (indexElements.Count - 1 >= s.Length) break;
        //        if (s[j] == letter)
        //        {
        //            if (!indexElements.Contains( i )) indexElements.Add( i );

        //            if (!indexElements.Contains( j )) indexElements.Add( j );
        //        }
        //    }
        //}

        //if (indexElements.Count == 0) return false;

        //for (int i = 0; i < indexElements.Count; i++)
        //{
        //    if (!(t[indexElements[i]] == t[indexElements[i + 1]]))
        //    {
        //        return false;
        //    }
        //}

        //return true;
    }
}