Console.WriteLine("Hello, World!");
// a e i o u
List<char> forbiddenLetters = new List<char>() { 'a', 'e', 'i', 'o', 'u' };

string input = "No offense but,\nYour writing is among the worst I've ever read";

string result = "";

for (int i = 0; i < input.Length; i++)
{
    if (forbiddenLetters.Contains(input.ToLower()[i]))
    {
        continue;
    }

    //Best solution
    // Regex.Replace(input,"[euioa","",RegexOptions.IgnoreCase)
    result += input[i];
}

Console.Write(result);