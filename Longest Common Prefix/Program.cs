using System.Runtime.ExceptionServices;
using System.Text;

Console.WriteLine( LongestCommonPrefix( new string[] { "cir", "car" } ) );
Console.WriteLine( LongestCommonPrefix( new string[] { "troll", "trall", "troll", "twall" } ) );

static string LongestCommonPrefix(string[] strs)
{
    if (strs[0].Length == 0) return "";
    var found = false;
    var shortes = strs.OrderBy( x => x.Length ).ToList().FirstOrDefault().Length;

    StringBuilder prefix = new StringBuilder();

    for (int i = 0; i < shortes; i++)
    {
        if (i == shortes || found) break;

        string current = strs[0];

        for (int j = 0; j < strs.Count();)
        {
            string next = strs[j++];
            if (current[i] != next[i])
            {
                found = true;
                break;
            }

            if (j == strs.Count())
            {
                prefix.Append( current[i] );
            }
        }
    }

    if (prefix.Length != 0)
    {
        return prefix.ToString();
    }
    GC.Collect();
    return "";
}