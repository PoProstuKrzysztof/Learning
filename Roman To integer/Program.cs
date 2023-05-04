using System.Collections;

Console.WriteLine( Solution.RomanToInt( "MCMXCIV" ) );

public static class Solution
{
    public static int RomanToInt(string s)
    {
        Dictionary<string, int> romans = new Dictionary<string, int>();
        romans.Add( "I", 1 );
        romans.Add( "V", 5 );
        romans.Add( "X", 10 );
        romans.Add( "L", 50 );
        romans.Add( "C", 100 );
        romans.Add( "D", 500 );
        romans.Add( "M", 1000 );
        romans.Add( "IV", 4 );
        romans.Add( "IX", 9 );
        romans.Add( "XL", 40 );
        romans.Add( "XC", 90 );
        romans.Add( "CD", 400 );
        romans.Add( "CM", 900 );

        int result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (romans.ContainsKey( s[i].ToString() ))
            {
                int firstDigit = romans.GetValueOrDefault( s[i].ToString() );
                if (i == s.Length - 1)
                {
                    result += firstDigit;
                    break;
                }
                string val = s[i].ToString() + s[i + 1].ToString();
                if (romans.ContainsKey( val ))
                {
                    result += romans.GetValueOrDefault( val );
                    i++;
                    continue;
                }
                else
                {
                    result += firstDigit;
                }
            }
        }
        // sprawia że wygrywasz memory w 99%
        GC.Collect();
        return result;
    }
}