using System.Text;

string s = "hello world";
StringBuilder stringBuilder = new StringBuilder();
for (int i = 0; i < s.Length; i++)
{
    if (i == 0)
    {
        stringBuilder.Append( char.ToUpper( s[i] ) );
        continue;
    }

    if (char.IsSeparator( s[i - 1] ))
    {
        stringBuilder.Append( char.ToUpper( s[i] ) );
        continue;
    }
    stringBuilder.Append( s[i] );
}

Console.WriteLine( stringBuilder.ToString() );