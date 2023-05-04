int a = 12;
string input = a.ToString();

List<char> output = new List<char>();

for (int i = 0; i < input.Length; i++)
{
    if (i == input.Length - 1)
    {
        if ((input[i] % 2 == 1) && (input[i - 1] % 2 == 1) || input[i - 1] == '0')
        {
            output[output.Count - 1] = input[i];
            break;
        }
        if ((input[i] % 2 == 0) && (input[i - 1] % 2 == 0))
        {
            output.Add( input[i] );
            break;
        }
        break;
    }

    if ((input[i] % 2 == 0) && (input[i + 1] % 2 == 0))
    {
        output.Add( input[i] );
        output.Add( '*' );
        continue;
    }
    if ((input[i] % 2 == 1) && (input[i + 1] % 2 == 1))
    {
        output.Add( input[i] );
        output.Add( '-' );

        continue;
    }

    output.Add( input[i] );
}

Console.WriteLine( output.ToArray() );

static string StringChallenge(int num)
{
    string input = num.ToString();

    List<char> output = new List<char>();

    for (int i = 0; i < input.Length; i++)
    {
        if (i == input.Length - 1)
        {
            if (input[i] % 2 == 1 && (input[i - 1] % 2 == 1) || input[i - 1] == '0')
            {
                output[output.Count - 1] = input[i];
                break;
            }

            if ((input[i] % 2 == 0) && (input[i - 1] % 2 == 0))
            {
                output.Add( input[i] );
                break;
            }
            break;
        }

        if ((input[i] % 2 == 0) && (input[i + 1] % 2) == 0)
        {
            output.Add( input[i] );
            output.Add( '*' );
            continue;
        }
        if ((input[i] % 2 == 1) && (input[i + 1] % 2) == 1)
        {
            output.Add( input[i] );
            output.Add( '-' );
            continue;
        }

        output.Add( input[i] );
    }
    return output.ToString();
}