Console.WriteLine("Should be 2: " + ReturnValue("abc abcd aaabcd abcdbddb"));

int ReturnValue(string exp)
{
    string[] words = exp.Split(' ');
    int result = 0;

    foreach (var word in words)
    {
        Dictionary<char, int> letters = new Dictionary<char, int>();
        foreach (var letter in word)
        {
            if (letters.ContainsKey(letter) && letters[letter] >= 3)
            {
                break;
            }

            if (letters.ContainsKey(letter))
            {
                letters[letter]++;
                if (letters[letter] >= 3)
                {
                    result++;
                    break;
                }
            }

            if (!letters.ContainsKey(letter))
            {
                letters.Add(letter, 1);
            }
        }
    }

    return result;
}